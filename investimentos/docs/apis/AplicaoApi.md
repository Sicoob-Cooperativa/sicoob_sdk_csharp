# Sicoob.Investimentos.Api.AplicaoApi

All URIs are relative to *https://api.sicoob.com.br/investimentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RendaFixaAportesPost**](AplicaoApi.md#rendafixaaportespost) | **POST** /renda-fixa/aportes | Realiza uma aplicação inteligente na cooperativa, conta da pessoa logada e modalidade informada. |

<a id="rendafixaaportespost"></a>
# **RendaFixaAportesPost**
> RendaFixaResgatesPost200Response RendaFixaAportesPost (string clientId, AplicacaoInteligente aplicacaoInteligente)

Realiza uma aplicação inteligente na cooperativa, conta da pessoa logada e modalidade informada.

A partir da cooperativa, conta da pessoa logada e da modalidade e valor informados é realizado uma aplicação.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **aplicacaoInteligente** | [**AplicacaoInteligente**](AplicacaoInteligente.md) |  |  |

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
| **200** | Aplicação inteligente feita com sucesso |  -  |
| **400** | Mensagem negocial |  -  |
| **401** | Usuário não autenticado |  -  |
| **415** | Unsupported Media Type |  -  |
| **500** | Erro interno do servidor |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

