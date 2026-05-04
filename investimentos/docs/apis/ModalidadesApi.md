# Sicoob.Investimentos.Api.ModalidadesApi

All URIs are relative to *https://api.sicoob.com.br/investimentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RendaFixaModalidadesGet**](ModalidadesApi.md#rendafixamodalidadesget) | **GET** /renda-fixa/modalidades | Realiza uma busca de modalidades ativas para a instituição e conta-corrente da pessoa logada considerando canal SISBR. |

<a id="rendafixamodalidadesget"></a>
# **RendaFixaModalidadesGet**
> RendaFixaModalidadesGet200Response RendaFixaModalidadesGet (string clientId)

Realiza uma busca de modalidades ativas para a instituição e conta-corrente da pessoa logada considerando canal SISBR.

Realiza uma busca de modalidades ativas para a instituição e conta-corrente da pessoa logada considerando canal SISBR.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |

### Return type

[**RendaFixaModalidadesGet200Response**](RendaFixaModalidadesGet200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Modalidades encontradas. |  -  |
| **204** | Modalidades inteligentes não puderam ser recuperadas. |  -  |
| **400** | Mensagem negocial |  -  |
| **401** | Usuário não autenticado |  -  |
| **500** | Erro interno do servidor |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

