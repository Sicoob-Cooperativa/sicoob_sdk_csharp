# Sicoob.CobrancaV3.Api.PagadorApi

All URIs are relative to *https://api.sicoob.com.br/cobranca-bancaria/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PagadoresPut**](PagadorApi.md#pagadoresput) | **PUT** /pagadores | Alterar informações do cadastro do pagador. |

<a id="pagadoresput"></a>
# **PagadoresPut**
> void PagadoresPut (Pagador pagador)

Alterar informações do cadastro do pagador.

Serviço para alterar informações do cadastro do pagador.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagador** | [**Pagador**](Pagador.md) | Informações do pagador. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Solicitação recebida com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

