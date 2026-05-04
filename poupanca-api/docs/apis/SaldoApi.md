# Sicoob.Poupanca.Api.SaldoApi

All URIs are relative to *https://api.sicoob.com.br/poupanca/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ObterSaldoContaPoupanca**](SaldoApi.md#obtersaldocontapoupanca) | **GET** /contas/{contaPoupanca}/saldo | Consulta de Saldo |

<a id="obtersaldocontapoupanca"></a>
# **ObterSaldoContaPoupanca**
> Saldo ObterSaldoContaPoupanca (long contaPoupanca, string clientId)

Consulta de Saldo

Consulta o saldo atual de uma conta poupança.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contaPoupanca** | **long** | Número da conta poupança |  |
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |

### Return type

[**Saldo**](Saldo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retorna o saldo atual da conta poupança informada. |  -  |
| **404** | Conta poupança não encontrada.  [Página de erros](/#!/erros) |  -  |
| **500** | Erro interno. [Página de erros](/#!/erros) |  -  |
| **503** | Serviço indisponível. [Página de erros](/#!/erros) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

