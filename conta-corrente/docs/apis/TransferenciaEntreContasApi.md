# Sicoob.ContaCorrente.Api.TransferenciaEntreContasApi

All URIs are relative to *https://api.sicoob.com.br/conta-corrente/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TransferirUsingPOST**](TransferenciaEntreContasApi.md#transferirusingpost) | **POST** /transferencias | Método que transfere os valores entre contas. |

<a id="transferirusingpost"></a>
# **TransferirUsingPOST**
> void TransferirUsingPOST (string clientId, string idToken, string xIdempotencyKey, TransferenciaEntreContaDTO transferenciaEntreContaDTO)

Método que transfere os valores entre contas.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **idToken** | **string** | Objeto destinado a autenticação do OpenBanking |  |
| **xIdempotencyKey** | **string** | Objeto destinado para a validação do LimitControl. Não pode ser duplicado. |  |
| **transferenciaEntreContaDTO** | [**TransferenciaEntreContaDTO**](TransferenciaEntreContaDTO.md) | Objeto destinado a Transferencia de valores |  |

### Return type

void (empty response body)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

