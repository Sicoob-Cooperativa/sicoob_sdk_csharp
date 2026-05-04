# Sicoob.Poupanca.Api.ExtratoApi

All URIs are relative to *https://api.sicoob.com.br/poupanca/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ObterExtratoContaPoupanca**](ExtratoApi.md#obterextratocontapoupanca) | **GET** /contas/{contaPoupanca}/extrato | Consulta de Extrato |

<a id="obterextratocontapoupanca"></a>
# **ObterExtratoContaPoupanca**
> Extrato ObterExtratoContaPoupanca (long contaPoupanca, int mes, int ano, string clientId)

Consulta de Extrato

Consulta o extrato de um mês e ano de uma conta poupança.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contaPoupanca** | **long** | Número da conta poupança |  |
| **mes** | **int** | Mês de consulta do extrato |  |
| **ano** | **int** | Ano de consulta do extrato |  |
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |

### Return type

[**Extrato**](Extrato.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retorna o extrato da conta poupança informada no devido mês e ano. |  -  |
| **404** | Conta poupança não encontrada. [Página de erros](/#!/erros) |  -  |
| **500** | Erro interno. [Página de erros](/#!/erros) |  -  |
| **503** | Serviço indisponível. [Página de erros](/#!/erros) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

