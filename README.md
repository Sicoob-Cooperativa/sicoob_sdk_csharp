# Sicoob SDK C# (.NET 8.0)

SDK Oficial em C# para integração com as APIs Financeiras e Não Financeiras do [Sicoob](https://developers.sicoob.com.br/).

Este SDK foi gerado a partir das especificações Swagger (OpenAPI) da Sicoob e foi projetado de forma **modular**, unificando as chamadas em um Client que gerencia a autenticação e certificados mTLS nativamente no .NET.

## Estrutura do Pacote

```text
sicoob_sdk_csharp/
├── auth/                         - API de Geração de Tokens
├── pix/                          - API Pix (Recebimentos, Cobranças imediatas)
├── pagamentos-pix/               - API Pagamentos Pix
├── cobrancav3/                   - API Cobrança Bancária V3 (Boletos)
├── pagamentosv3/                 - API Cobrança Bancária Pagamentos
├── conta-corrente/               - API Conta Corrente (Extrato, Saldo)
├── convenio-pagamentos/          - API Arrecadação e Convênios
├── investimentos/                - API Investimentos Renda Fixa
├── poupanca-api/                 - API de Poupança (Extrato, Saldo)
├── openfinance-consentimento/    - API Open Finance Consentimentos
├── spb-transferencias/           - API Transferências SPB (TEDs)
└── SicoobClient.cs               - Orquestrador principal unificado
```

## Requisitos de Autenticação e mTLS (Certificados)

O cliente HTTP subjacente ao SDK C# (usando a classe `HttpClient` e `HttpClientHandler` do .NET Core) tem **suporte nativo e otimizado** aos certificados corporativos em formato `.pfx` ou `.p12` através da classe `X509Certificate2`.

Portanto, **não é necessária a conversão do seu certificado `.pfx`** para PEM no C#.

## Exemplo de Uso

Instancie a classe `SicoobClient` passando o Client ID, o caminho do seu certificado digital `.pfx` e a respectiva senha.

O token gerado será automaticamente distribuído pelo cabeçalho `Authorization: Bearer <token>` de forma injetada no `HttpClient` compartilhado, garantindo performance de pooling e servindo todas as APIs do Sicoob.

```csharp
using System;
using Sicoob;
using Sicoob.ContaCorrente.Model;

namespace ExemploSicoob
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instanciando passando um .pfx e sua respectiva senha
                // O último parâmetro (isSandbox) define se vai rodar em Prod ou Sandbox (false = Produção)
                var sicoob = new SicoobClient(
                    "SEU_CLIENT_ID",
                    "/caminho/para/certificado/KA5 TELECON E-CNPJ A1 2026.pfx",
                    "SENHA_DO_PFX",
                    false
                );

                // --- EM AMBIENTE DE PRODUÇÃO ---
                // Autentica (gera o Token e injeta no HttpClient compartilhado)
                // É obrigatório informar os escopos desejados na primeira chamada
                string token = sicoob.Authenticate("cco_transferencias cco_consulta openid");
                Console.WriteLine("Token gerado: " + token);

                // --- EM AMBIENTE DE SANDBOX ---
                // Em Sandbox, não chame o Authenticate(). Obtenha o token fixo no Portal Developers e injete:
                // sicoob.SetSandboxToken("1301865f-c6bc-38f3-9f49-666dbcfc59c3");

                // Exemplo: Consultar Conta Corrente
                // Nota: Substituir o 12345L pelo número correto da conta corrente
                Saldo responseSaldo = sicoob.ContaCorrenteSaldoApi.ContasNumeroContaCorrenteSaldoGet(12345L);
                Console.WriteLine("Saldo: " + responseSaldo.Resultado.SaldoDisponivel);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na execução: " + ex.Message);
            }
        }
    }
}
```

### 🔄 Renovação Automática de Token

O SDK possui inteligência embutida (`DelegatingHandler` customizado do `HttpClient`) para lidar com a expiração do token OAuth2. 
Ao receber um erro `401 Unauthorized` de qualquer API de negócio, o Client intercepta a falha, utiliza os escopos informados na primeira autenticação para gerar um novo token de acesso, e refaz a requisição original de forma 100% transparente. Você não precisa se preocupar com caches ou temporizadores na sua aplicação!

## Instalação

Para utilizar todo o SDK unificado (junto do orquestrador `SicoobClient`), você deve instalar o pacote NuGet unificado `Sicoob.Sdk`.

```bash
dotnet add package Sicoob.Sdk
```

Ao fazer isso, todas as abstrações, classes, modelos e APIs do Sicoob estarão disponíveis na sua aplicação, sem precisar instalar cada módulo individualmente.


## Escopos (Scopes) por API

Ao chamar o método de autenticação, dependendo da API que você for utilizar, é estritamente necessário fornecer os escopos (scopes) apropriados separados por espaço. Abaixo a tabela de referência das APIs e seus escopos:

| API de Negócio | Escopos Comuns Necessários |
|---|---|
| **Cobrança Bancária V3** | `cobranca_boletos_consultar` `cobranca_boletos_incluir` `cobranca_boletos_pagador` `cobranca_boletos_segunda_via` `cobranca_boletos_baixa` `cobranca_boletos_rateio_credito` |
| **Cobrança Bancária Pagamentos** | `pagamentos_boletos_pagar` `pagamentos_boletos_agendar` `pagamentos_boletos_consultar` |
| **Conta Corrente** | `cco_extrato` `cco_saldo` `cco_transferencias` |
| **Convênio Pagamentos** | `conveniopagamentos_arrecadacao` `conveniopagamentos_debitos_automaticos` |
| **Investimentos** | `investimentos_renda_fixa` |
| **Open Finance** | `openid` (Necessita de diretrizes específicas do fluxo OIDC) |
| **Pagamentos PIX** | `pixpagamentos_escrita` `pixpagamentos_consulta` `pixpagamentos_webhook` |
| **PIX (Recebimentos)** | `cob.read` `cob.write` `cobv.read` `cobv.write` `lotecobv.read` `lotecobv.write` `pix.read` `pix.write` `webhook.read` `webhook.write` `payloadlocation.read` `payloadlocation.write` |
| **Poupança** | `poupanca_saldo` `poupanca_extrato` `poupanca_aplicacao` `poupanca_resgate` |
| **SPB Transferências** | `spb_transferencias_ted` |

*Nota: Alguns escopos exigem liberação específica nas chaves da sua aplicação no Portal de Desenvolvedores do Sicoob.*

## Documentação Específica

Para detalhes exatos sobre métodos, parâmetros de requisição e construtores de DTO de cada API, verifique o `README.md` individual que foi gerado dentro da pasta de cada submódulo:

- [API Autenticação](auth/README.md)
- [API Pix (Recebimentos e Cobranças)](pix/README.md)
- [API Pagamentos Pix](pagamentos-pix/README.md)
- [API Cobrança Bancária V3 (Boletos)](cobrancav3/README.md)
- [API Pagamentos de Cobrança (DDA)](pagamentosv3/README.md)
- [API Conta Corrente](conta-corrente/README.md)
- [API Convênio / Pagamentos](convenio-pagamentos/README.md)
- [API Investimentos](investimentos/README.md)
- [API Poupança](poupanca-api/README.md)
- [API Transferências SPB (TEDs)](spb-transferencias/README.md)
- [API OpenFinance Consentimentos](openfinance-consentimento/README.md)
