using System;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
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

        private HttpClient _httpClient;

        // Custom DelegatingHandler for 401 retries
        private class RetryUnauthorizedHandler : DelegatingHandler
        {
            private readonly SicoobClient _sicoobClient;

            public RetryUnauthorizedHandler(SicoobClient sicoobClient, HttpMessageHandler innerHandler) : base(innerHandler)
            {
                _sicoobClient = sicoobClient;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await base.SendAsync(request, cancellationToken);

                // If 401 Unauthorized and it's not a request to the auth token endpoint itself
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized && !request.RequestUri.AbsolutePath.Contains("/token"))
                {
                    if (_sicoobClient.IsSandbox)
                    {
                        return response;
                    }

                    try
                    {
                        // Renew token
                        string newToken = _sicoobClient.Authenticate();

                        // Clone request and set new Bearer token
                        var newRequest = await CloneRequestAsync(request);
                        newRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", newToken);

                        // Retry with new request
                        response = await base.SendAsync(newRequest, cancellationToken);
                    }
                    catch (Exception)
                    {
                        // If token renewal fails, just return original 401 response
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

                foreach (System.Collections.Generic.KeyValuePair<string, object> prop in req.Properties)
                    clone.Properties.Add(prop);

                foreach (System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>> header in req.Headers)
                    clone.Headers.TryAddWithoutValidation(header.Key, header.Value);

                return clone;
            }
        }

        // APIs
        public IAutenticaoApi AuthApi { get; private set; }
        public IPixApi PixApi { get; private set; }
        public ICobApi PixCobApi { get; private set; }
        public IAPIDePagamentosPIXApi PagamentosPixApi { get; private set; }
        public IPagamentoApi PagamentosV3Api { get; private set; }
        public IBoletosApi CobrancaV3BoletosApi { get; private set; }
        public IExtratoApi ContaCorrenteExtratoApi { get; private set; }
        public ISaldoApi ContaCorrenteSaldoApi { get; private set; }
        public IArrecadaoApi ArrecadacaoApi { get; private set; }
        public IInvestimentosApi InvestimentosApi { get; private set; }
        public IIniciadorDeTransaesDePagamentoApi OpenFinanceConsentsApi { get; private set; }
        public Sicoob.Poupanca.Api.ISaldoApi PoupancaSaldoApi { get; private set; }
        public ITEDsApi SpbTedsApi { get; private set; }

        public SicoobClient(string clientId, string pfxPath, string pfxPassword) : this(clientId, pfxPath, pfxPassword, false)
        {
        }

        public SicoobClient(string clientId, string pfxPath, string pfxPassword, bool isSandbox)
        {
            this.ClientId = clientId;
            this.PfxPath = pfxPath;
            this.PfxPassword = pfxPassword;
            this.IsSandbox = isSandbox;

            this._httpClient = CreateHttpClient();

            string baseUrl = this.IsSandbox ? "https://sandbox.sicoob.com.br/sicoob/sandbox" : "https://api.sicoob.com.br";
            string authUrl = this.IsSandbox ? "https://sandbox.sicoob.com.br/sicoob/sandbox" : "https://auth.sicoob.com.br";

            // Configura Auth
            var authConfig = new Sicoob.Auth.Client.Configuration { BasePath = authUrl };
            this.AuthApi = new AutenticaoApi(_httpClient, authConfig);

            // Configura Pix
            var pixConfig = new Sicoob.Pix.Client.Configuration { BasePath = $"{baseUrl}/pix/api/v2" };
            this.PixApi = new PixApi(_httpClient, pixConfig);
            this.PixCobApi = new CobApi(_httpClient, pixConfig);

            // Configura Pagamentos Pix
            var pagPixConfig = new Sicoob.PagamentosPix.Client.Configuration { BasePath = $"{baseUrl}/pix-pagamentos/v2" };
            this.PagamentosPixApi = new APIDePagamentosPIXApi(_httpClient, pagPixConfig);

            // Configura Pagamentos V3
            var pagV3Config = new Sicoob.PagamentosV3.Client.Configuration { BasePath = $"{baseUrl}/pagamentos/v3" };
            this.PagamentosV3Api = new PagamentoApi(_httpClient, pagV3Config);

            // Configura Cobrança V3
            var cobV3Config = new Sicoob.CobrancaV3.Client.Configuration { BasePath = $"{baseUrl}/cobranca-bancaria/v3" };
            this.CobrancaV3BoletosApi = new BoletosApi(_httpClient, cobV3Config);

            // Configura Conta Corrente
            var contaConfig = new Sicoob.ContaCorrente.Client.Configuration { BasePath = $"{baseUrl}/conta-corrente/v4" };
            this.ContaCorrenteExtratoApi = new ExtratoApi(_httpClient, contaConfig);
            this.ContaCorrenteSaldoApi = new SaldoApi(_httpClient, contaConfig);

            // Configura Convenio
            var convenioConfig = new Sicoob.ConvenioPagamentos.Client.Configuration { BasePath = $"{baseUrl}/convenios-pagamentos/v2" };
            this.ArrecadacaoApi = new ArrecadaoApi(_httpClient, convenioConfig);

            // Configura Investimentos
            var investConfig = new Sicoob.Investimentos.Client.Configuration { BasePath = $"{baseUrl}/investimentos/v2" };
            this.InvestimentosApi = new InvestimentosApi(_httpClient, investConfig);

            // Configura Open Finance
            var openConfig = new Sicoob.OpenFinance.Client.Configuration { BasePath = $"{baseUrl}/payments/v2/itp" };
            this.OpenFinanceConsentsApi = new IniciadorDeTransaesDePagamentoApi(_httpClient, openConfig);

            // Configura Poupanca
            var poupancaConfig = new Sicoob.Poupanca.Client.Configuration { BasePath = $"{baseUrl}/poupanca/v3" };
            this.PoupancaSaldoApi = new Sicoob.Poupanca.Api.SaldoApi(_httpClient, poupancaConfig);

            // Configura SPB
            var spbConfig = new Sicoob.SpbTransferencias.Client.Configuration { BasePath = $"{baseUrl}/spb/v2" };
            this.SpbTedsApi = new TEDsApi(_httpClient, spbConfig);
        }

        private HttpClient CreateHttpClient()
        {
            var handler = new HttpClientHandler();

            if (!string.IsNullOrEmpty(this.PfxPath))
            {
                var certificate = new X509Certificate2(this.PfxPath, this.PfxPassword);
                handler.ClientCertificates.Add(certificate);
            }

            // Wrap inner handler with RetryUnauthorizedHandler
            var retryHandler = new RetryUnauthorizedHandler(this, handler);

            return new HttpClient(retryHandler);
        }

        public void SetSandboxToken(string token)
        {
            this.AccessToken = token;
            this._httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.AccessToken);
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

            if (this.CurrentScopes == null)
            {
                throw new Exception("Scopes must be provided on the first authentication.");
            }

            var response = this.AuthApi.AuthRealmsCooperadoProtocolOpenidConnectTokenPost("client_credentials", this.ClientId, this.CurrentScopes);
            this.AccessToken = response.AccessToken;

            // Injeta o token como Default Request Header no HttpClient (global para a instancia)
            this._httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.AccessToken);

            return this.AccessToken;
        }
    }
}
