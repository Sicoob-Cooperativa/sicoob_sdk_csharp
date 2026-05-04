# Sicoob.Investimentos.Api.ResgateApi

All URIs are relative to *https://api.sicoob.com.br/investimentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RendaFixaResgatesPost**](ResgateApi.md#rendafixaresgatespost) | **POST** /renda-fixa/resgates | Realiza um resgate inteligente na cooperativa e conta da pessoa logada. |

<a id="rendafixaresgatespost"></a>
# **RendaFixaResgatesPost**
> RendaFixaResgatesPost200Response RendaFixaResgatesPost (string clientId, ResgateInteligenteCapRem resgateInteligenteCapRem)

Realiza um resgate inteligente na cooperativa e conta da pessoa logada.

A partir da cooperativa, conta da pessoa logada e valor passado é realizado um resgaste inteligente.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **resgateInteligenteCapRem** | [**ResgateInteligenteCapRem**](ResgateInteligenteCapRem.md) |  |  |

### Return type

[**RendaFixaResgatesPost200Response**](RendaFixaResgatesPost200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resgate realizado |  -  |
| **400** | Mensagem negocial |  -  |
| **401** | Usuário não autenticado |  -  |
| **415** | Unsupported Media Type |  -  |
| **500** | Erro interno do servidor |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

