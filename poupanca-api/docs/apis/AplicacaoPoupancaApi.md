# Sicoob.Poupanca.Api.AplicacaoPoupancaApi

All URIs are relative to *https://api.sicoob.com.br/poupanca/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Aplicacao**](AplicacaoPoupancaApi.md#aplicacao) | **POST** /aplicacoes | Aplicação de uma conta vinculada |

<a id="aplicacao"></a>
# **Aplicacao**
> RetornoTransferencia Aplicacao (string clientId, Transferencia aplicacao)

Aplicação de uma conta vinculada

Realiza uma aplicacao de uma conta corrente vinculada para uma conta conta poupança com os parametros informados.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |
| **aplicacao** | [**Transferencia**](Transferencia.md) | Parametros a serem preenchidos com os dados da aplicacao |  |

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
| **201** | Aplicacao realizado com sucesso |  -  |
| **400** | Ocorreu um erro na operação |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

