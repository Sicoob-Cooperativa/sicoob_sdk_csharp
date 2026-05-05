using System;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sicoob.Auth.Api;
using Sicoob.Pix.Api;
using Sicoob.PagamentosPix.Api;
using Sicoob.PagamentosV3.Api;
using Sicoob.CobrancaV3.Api;
using Sicoob.ContaCorrente.Api;
using Sicoob.ConvenioPagamentos.Api;
using Sicoob.Investimentos.Api;
using Sicoob.OpenFinance.Api;
using Sicoob.Poupanca.Api;
using Sicoob.SpbTransferencias.Api;

namespace Sicoob
{
    public class SicoobClient
    {
        public string ClientId { get; private set; }
        public string PfxPath { get; private set; }
        private string PfxPassword;
        private string AccessToken;
        private string CurrentScopes;
        private bool IsSandbox;

        private IServiceProvider _serviceProvider;

        // Custom DelegatingHandler for 401 retries
        private class RetryUnauthorizedHandler : DelegatingHandler
        {
            private readonly SicoobClient _sicoobClient;

            public RetryUnauthorizedHandler(SicoobClient sicoobClient)
            {
                _sicoobClient = sicoobClient;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (_sicoobClient.AccessToken != null)
                {
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _sicoobClient.AccessToken);
                }

                // Inject client_id header globally for all APIs
                if (!string.IsNullOrEmpty(_sicoobClient.ClientId))
                {
                    if (request.Headers.Contains("client_id"))
                    {
                        request.Headers.Remove("client_id");
                    }
                    request.Headers.Add("client_id", _sicoobClient.ClientId);
                }

                var response = await base.SendAsync(request, cancellationToken);

                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized && !request.RequestUri.AbsolutePath.Contains("/token"))
                {
                    if (_sicoobClient.IsSandbox)
                    {
                        return response;
                    }

                    try
                    {
                        string newToken = _sicoobClient.Authenticate();
                        _sicoobClient.AccessToken = newToken;
                        
                        var newRequest = await CloneRequestAsync(request);
                        newRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", newToken);

                        response = await base.SendAsync(newRequest, cancellationToken);
                    }
                    catch (Exception)
                    {
                    }
                }

                return response;
            }

            private async Task<HttpRequestMessage> CloneRequestAsync(HttpRequestMessage req)
            {
                HttpRequestMessage clone = new HttpRequestMessage(req.Method, req.RequestUri);
                if (req.Content != null)
                {
                    var stream = new System.IO.MemoryStream();
                    await req.Content.CopyToAsync(stream);
                    stream.Position = 0;
                    clone.Content = new StreamContent(stream);
                    if (req.Content.Headers != null)
                    {
                        foreach (var h in req.Content.Headers)
                            clone.Content.Headers.Add(h.Key, h.Value);
                    }
                }
                clone.Version = req.Version;
                // Avoid using deprecated Properties
#if NET5_0_OR_GREATER
                foreach (var prop in req.Options)
                    clone.Options.Set(new HttpRequestOptionsKey<object?>(prop.Key), prop.Value);
#endif
                foreach (var header in req.Headers)
                    clone.Headers.TryAddWithoutValidation(header.Key, header.Value);

                return clone;
            }
        }

        public IAutenticaoApi AuthApi => _serviceProvider.GetRequiredService<IAutenticaoApi>();
        public IPixApi PixApi => _serviceProvider.GetRequiredService<IPixApi>();
        public ICobApi PixCobApi => _serviceProvider.GetRequiredService<ICobApi>();
        public IAPIDePagamentosPIXApi PagamentosPixApi => _serviceProvider.GetRequiredService<IAPIDePagamentosPIXApi>();
        public IPagamentoApi PagamentosV3Api => _serviceProvider.GetRequiredService<IPagamentoApi>();
        public IBoletoApi CobrancaV3BoletosApi => _serviceProvider.GetRequiredService<IBoletoApi>();
        public Sicoob.ContaCorrente.Api.IExtratoApi ContaCorrenteExtratoApi => _serviceProvider.GetRequiredService<Sicoob.ContaCorrente.Api.IExtratoApi>();
        public Sicoob.ContaCorrente.Api.ISaldoApi ContaCorrenteSaldoApi => _serviceProvider.GetRequiredService<Sicoob.ContaCorrente.Api.ISaldoApi>();
        public IArrecadaoApi ArrecadacaoApi => _serviceProvider.GetRequiredService<IArrecadaoApi>();
        public IInvestimentosApi InvestimentosApi => _serviceProvider.GetRequiredService<IInvestimentosApi>();
        public IIniciadorDeTransaesDePagamentoApi OpenFinanceConsentsApi => _serviceProvider.GetRequiredService<IIniciadorDeTransaesDePagamentoApi>();
        public Sicoob.Poupanca.Api.ISaldoApi PoupancaSaldoApi => _serviceProvider.GetRequiredService<Sicoob.Poupanca.Api.ISaldoApi>();
        public ITEDsApi SpbTedsApi => _serviceProvider.GetRequiredService<ITEDsApi>();

        public SicoobClient(string clientId, string pfxPath, string pfxPassword) : this(clientId, pfxPath, pfxPassword, false)
        {
        }

        public SicoobClient(string clientId, string pfxPath, string pfxPassword, bool isSandbox)
        {
            this.ClientId = clientId;
            this.PfxPath = pfxPath;
            this.PfxPassword = pfxPassword;
            this.IsSandbox = isSandbox;
            
            // Allow empty for compilation issues
            this.AccessToken = string.Empty;
            this.CurrentScopes = string.Empty;

            var services = new ServiceCollection();
            services.AddLogging(builder => builder.AddConsole());

            string baseUrl = this.IsSandbox ? "https://sandbox.sicoob.com.br/sicoob/sandbox" : "https://api.sicoob.com.br";
            string authUrl = this.IsSandbox ? "https://sandbox.sicoob.com.br/sicoob/sandbox" : "https://auth.sicoob.com.br";

            services.AddTransient<RetryUnauthorizedHandler>(sp => new RetryUnauthorizedHandler(this));

            var configureClient = (HttpClient client, string path) => {
                client.BaseAddress = new Uri(path);
            };

            var configureBuilder = (IHttpClientBuilder builder) => {
                builder.ConfigurePrimaryHttpMessageHandler(() => {
                    var handler = new HttpClientHandler();
                    if (!string.IsNullOrEmpty(this.PfxPath))
                    {
                        var certificate = new X509Certificate2(this.PfxPath, this.PfxPassword);
                        handler.ClientCertificates.Add(certificate);
                    }
                    return handler;
                });
                builder.AddHttpMessageHandler<RetryUnauthorizedHandler>();
            };


            // Configura APIs
            new Sicoob.Auth.Client.HostConfiguration(services)
                .AddApiHttpClients(c => configureClient(c, authUrl), configureBuilder);

            new Sicoob.Pix.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.Pix.Client.OAuthToken("token"))
                .UseProvider<Sicoob.Pix.Client.RateLimitProvider<Sicoob.Pix.Client.OAuthToken>, Sicoob.Pix.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/pix/api/v2"), configureBuilder);

            new Sicoob.PagamentosPix.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.PagamentosPix.Client.OAuthToken("token"))
                .UseProvider<Sicoob.PagamentosPix.Client.RateLimitProvider<Sicoob.PagamentosPix.Client.OAuthToken>, Sicoob.PagamentosPix.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/pix-pagamentos/v2"), configureBuilder);

            new Sicoob.PagamentosV3.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.PagamentosV3.Client.OAuthToken("token"))
                .UseProvider<Sicoob.PagamentosV3.Client.RateLimitProvider<Sicoob.PagamentosV3.Client.OAuthToken>, Sicoob.PagamentosV3.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/pagamentos/v3"), configureBuilder);

            new Sicoob.CobrancaV3.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.CobrancaV3.Client.OAuthToken("token"))
                .UseProvider<Sicoob.CobrancaV3.Client.RateLimitProvider<Sicoob.CobrancaV3.Client.OAuthToken>, Sicoob.CobrancaV3.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/cobranca-bancaria/v3"), configureBuilder);

            new Sicoob.ContaCorrente.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.ContaCorrente.Client.OAuthToken("token"))
                .UseProvider<Sicoob.ContaCorrente.Client.RateLimitProvider<Sicoob.ContaCorrente.Client.OAuthToken>, Sicoob.ContaCorrente.Client.OAuthToken>()
                .AddTokens(new Sicoob.ContaCorrente.Client.ApiKeyToken(this.ClientId, Sicoob.ContaCorrente.Client.ClientUtils.ApiKeyHeader.Client_id, ""))
                .UseProvider<Sicoob.ContaCorrente.Client.RateLimitProvider<Sicoob.ContaCorrente.Client.ApiKeyToken>, Sicoob.ContaCorrente.Client.ApiKeyToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/conta-corrente/v4"), configureBuilder);

            new Sicoob.ConvenioPagamentos.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.ConvenioPagamentos.Client.OAuthToken("token"))
                .UseProvider<Sicoob.ConvenioPagamentos.Client.RateLimitProvider<Sicoob.ConvenioPagamentos.Client.OAuthToken>, Sicoob.ConvenioPagamentos.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/convenios-pagamentos/v2"), configureBuilder);

            new Sicoob.Investimentos.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.Investimentos.Client.OAuthToken("token"))
                .UseProvider<Sicoob.Investimentos.Client.RateLimitProvider<Sicoob.Investimentos.Client.OAuthToken>, Sicoob.Investimentos.Client.OAuthToken>()
                .AddTokens(new Sicoob.Investimentos.Client.ApiKeyToken(this.ClientId, Sicoob.Investimentos.Client.ClientUtils.ApiKeyHeader.Client_id, ""))
                .UseProvider<Sicoob.Investimentos.Client.RateLimitProvider<Sicoob.Investimentos.Client.ApiKeyToken>, Sicoob.Investimentos.Client.ApiKeyToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/investimentos/v2"), configureBuilder);

            new Sicoob.OpenFinance.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.OpenFinance.Client.OAuthToken("token"))
                .UseProvider<Sicoob.OpenFinance.Client.RateLimitProvider<Sicoob.OpenFinance.Client.OAuthToken>, Sicoob.OpenFinance.Client.OAuthToken>()
                .AddTokens(new Sicoob.OpenFinance.Client.ApiKeyToken(this.ClientId, Sicoob.OpenFinance.Client.ClientUtils.ApiKeyHeader.Client_id, ""))
                .UseProvider<Sicoob.OpenFinance.Client.RateLimitProvider<Sicoob.OpenFinance.Client.ApiKeyToken>, Sicoob.OpenFinance.Client.ApiKeyToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/payments/v2/itp"), configureBuilder);

            new Sicoob.Poupanca.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.Poupanca.Client.OAuthToken("token"))
                .UseProvider<Sicoob.Poupanca.Client.RateLimitProvider<Sicoob.Poupanca.Client.OAuthToken>, Sicoob.Poupanca.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/poupanca/v3"), configureBuilder);

            new Sicoob.SpbTransferencias.Client.HostConfiguration(services)
                .AddTokens(new Sicoob.SpbTransferencias.Client.OAuthToken("token"))
                .UseProvider<Sicoob.SpbTransferencias.Client.RateLimitProvider<Sicoob.SpbTransferencias.Client.OAuthToken>, Sicoob.SpbTransferencias.Client.OAuthToken>()
                .AddApiHttpClients(c => configureClient(c, $"{baseUrl}/spb/v2"), configureBuilder);

            _serviceProvider = services.BuildServiceProvider();
            
        }

        public void SetSandboxToken(string token)
        {
            this.AccessToken = token;
        }

        public string Authenticate(string scopes = null)
        {
            if (this.IsSandbox)
            {
                throw new Exception("Em ambiente Sandbox, não chame o Authenticate(), ao invés disso, utilize o método SetSandboxToken('token-aqui') passando o token fixo gerado pelo Portal Sicoob Developers.");
            }

            if (scopes != null)
            {
                this.CurrentScopes = scopes;
            }

            if (string.IsNullOrEmpty(this.CurrentScopes))
            {
                throw new Exception("Scopes must be provided on the first authentication.");
            }

            // Sync call
            var task = this.AuthApi.AuthRealmsCooperadoProtocolOpenidConnectTokenPostAsync(this.ClientId, "client_credentials", this.CurrentScopes);
            task.Wait();
            var response = task.Result;
            
            // Allow accessing .Ok() securely based on ApiResponse layout
            if (response.IsSuccessStatusCode)
            {
                var content = response.Ok();
                if (content != null)
                {
                    this.AccessToken = content.AccessToken;
                }
            }
            else
            {
                throw new Exception($"Authentication failed with status: {response.StatusCode} - {response.RawContent}");
            }

            return this.AccessToken;
        }
    }
}
