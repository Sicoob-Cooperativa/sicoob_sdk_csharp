# Sicoob.Poupanca.Api.ResgatePoupancaApi

All URIs are relative to *https://api.sicoob.com.br/poupanca/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Resgates**](ResgatePoupancaApi.md#resgates) | **POST** /resgates | Resgatar de uma conta poupança vinculada |

<a id="resgates"></a>
# **Resgates**
> RetornoTransferencia Resgates (string clientId, Transferencia aplicacao)

Resgatar de uma conta poupança vinculada

Realiza um resgate de uma conta poupança para uma conta corrente vinculadas com os parametros informados.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |
| **aplicacao** | [**Transferencia**](Transferencia.md) | Parametros a serem preenchidos com os dados do resgate |  |

### Return type

[**RetornoTransferencia**](RetornoTransferencia.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Resgate realizado com sucesso |  -  |
| **400** | Ocorreu um erro na operação |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

