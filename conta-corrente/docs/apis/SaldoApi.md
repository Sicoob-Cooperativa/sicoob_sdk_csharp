# Sicoob.ContaCorrente.Api.SaldoApi

All URIs are relative to *https://api.sicoob.com.br/conta-corrente/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ObterSaldo**](SaldoApi.md#obtersaldo) | **GET** /saldo | O recurso de Saldo retorna o valor disponivel atual, o limite de credito (cheque especial) e o saldo bloqueado de uma conta corrente. |

<a id="obtersaldo"></a>
# **ObterSaldo**
> Saldo ObterSaldo (string clientId, long numeroContaCorrente = null)

O recurso de Saldo retorna o valor disponivel atual, o limite de credito (cheque especial) e o saldo bloqueado de uma conta corrente.

Saldo bancario


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **numeroContaCorrente** | **long** | Numero da conta corrente (pessoa juridica). | [optional]  |

### Return type

[**Saldo**](Saldo.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso |  -  |
| **400** | Ocorreu um erro negocial |  -  |
| **500** | Erro interno de servidor |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

