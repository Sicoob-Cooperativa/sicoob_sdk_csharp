# Created with Openapi Generator

<a id="cli"></a>
## Creating the library
Create a config.yaml file similar to what is below, then run the following powershell command to generate the library `java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate -c config.yaml`

```yaml
generatorName: csharp
inputSpec: /home/naruto/Desktop/sicoob-sdks/swagger/convenio-pagamentos.json
outputDir: out

# https://openapi-generator.tech/docs/generators/csharp
additionalProperties:
  packageGuid: '{2EF6CB49-BBC7-4A92-BF72-723198E58A25}'

# https://openapi-generator.tech/docs/integrations/#github-integration
# gitHost:
# gitUserId:
# gitRepoId:

# https://openapi-generator.tech/docs/globals
# globalProperties:

# https://openapi-generator.tech/docs/customization/#inline-schema-naming
# inlineSchemaOptions:

# https://openapi-generator.tech/docs/customization/#name-mapping
# modelNameMappings:
# nameMappings:

# https://openapi-generator.tech/docs/customization/#openapi-normalizer
# openapiNormalizer:

# templateDir: https://openapi-generator.tech/docs/templating/#modifying-templates

# releaseNote:
```

<a id="usage"></a>
## Using the library in your project

```cs
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Sicoob.ConvenioPagamentos.Api;
using Sicoob.ConvenioPagamentos.Client;
using Sicoob.ConvenioPagamentos.Model;
using Org.OpenAPITools.Extensions;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IArrecadaoApi>();
            IArrecadacaoCodigoBarrasCodigoBarrasGetApiResponse apiResponse = await api.ArrecadacaoCodigoBarrasCodigoBarrasGetAsync("todo");
            ArrecadacaoCodigoBarrasCodigoBarrasGet200Response? model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, services, options) =>
          {
              // The type of token here depends on the api security specifications
              // Available token types are ApiKeyToken, BasicToken, BearerToken, HttpSigningToken, and OAuthToken.
              BearerToken token = new("<your token>");
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<BearerToken>, BearerToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(client =>
              {
                  // client configuration
              }, builder =>
              {
                  builder
                      .AddRetryPolicy(2)
                      .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                      .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30));
                      // add whatever middleware you prefer
                  }
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  Configure Polly in the IHttpClientBuilder
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null.
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After partial methods in the api classes.

## Api Information
- appName: Convênios Pagamentos
- appVersion: 2.0.11.1
- appDescription: &lt;pre&gt;[ Base URL: https://api.sicoob.com.br/convenios-pagamentos/v2 ]&lt;/pre&gt; A &lt;b&gt;API de Arrecadação de Convênios&lt;/b&gt; disponibiliza serviços que permitem a liquidação de convênios de arrecadação firmados pelo Banco Sicoob com entes públicos ou concessionárias. Ao habilitar a API, cada usuário será atribuído a um perfil de acesso:  &lt;b&gt;Cooperado&lt;/b&gt; – Perfil destinado a pequenos volumes de arrecadação.  &lt;b&gt;Parceiro Cooperativa&lt;/b&gt; – Perfil com alta taxa de requisições dentro de um intervalo de tempo.  &lt;b&gt;Parceiro Banco&lt;/b&gt; – Perfil com alta taxa de requisições dentro de um intervalo de tempo.  O cooperado ou correntista do Sicoob deverá verificar sua situação cadastral junto à cooperativa para aderir ao perfil que melhor se enquadra às suas necessidades. Para parceiros &lt;b&gt;Cooperativa&lt;/b&gt; ou &lt;b&gt;Banco Sicoob&lt;/b&gt;, que demandam o processamento de grandes volumes de transações de arrecadação de convênios, o acesso é segmentado, assegurando &lt;b&gt;performance&lt;/b&gt; e &lt;b&gt;integridade&lt;/b&gt; na execução.  &lt;b&gt;Regras para grandes volumes de arrecadação:&lt;/b&gt; Parceiros que necessitam consumir uma alta taxa de requisições em intervalos de milissegundos devem observar o &lt;b&gt;Rate Limit&lt;/b&gt; definido pelo serviço. Esse limite restringe a quantidade de chamadas permitidas por segundo, evitando bloqueios ou erros de excesso de requisições (&lt;b&gt;HTTP 429&lt;/b&gt;).  Para otimizar o desempenho, parceiros que utilizam a API com grande volume ou múltiplas requisições por segundo serão caracterizados e tratados de forma diferenciada, garantindo uma abordagem adequada às suas demandas.  &lt;b&gt;Parceiros de grande volume serão classificados em dois tipos:&lt;/b&gt;  &lt;b&gt;Parceiro Banco Sicoob&lt;/b&gt;: parceiro com contrato de arrecadação de convênios ativo diretamente com o Banco Sicoob.  &lt;b&gt;Parceiro Cooperativa&lt;/b&gt;: parceiro com contrato de arrecadação de convênios ativo com a Cooperativa e vinculado ao Banco Sicoob.  &lt;b&gt;Orientações de suporte:&lt;/b&gt; Em caso de necessidade de processamento de grandes volumes de requisições, recomendamos entrar em contato com a &lt;b&gt;Área de Relacionamento da sua Cooperativa&lt;/b&gt; ou diretamente com a &lt;b&gt;Gerência de Operações Bancárias II&lt;/b&gt;, por meio dos canais oficiais de comunicação disponíveis.  &lt;b&gt;Observação importante:&lt;/b&gt; &lt;b&gt;Exclusivo para o perfil “Parceiro Banco Sicoob”:&lt;/b&gt; no serviço de arrecadação com &lt;b&gt;código de barras&lt;/b&gt;, é obrigatório informar o atributo &lt;b&gt;NSU&lt;/b&gt; na transação.  &lt;b&gt;Atenção:&lt;/b&gt; Outra maneira fácil de entrar em contato com o suporte de APIs do Sicoob é via WhatsApp. Basta escrever o termo &lt;b&gt;#API&lt;/b&gt; e enviar para o número &lt;b&gt;61 4000-1111&lt;/b&gt;. O time de suporte estará disponível para atendê-lo das 09h às 18h30 durante os dias úteis.

## Build
This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.

- SDK version: 1.0.0
- Generator version: 7.22.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
