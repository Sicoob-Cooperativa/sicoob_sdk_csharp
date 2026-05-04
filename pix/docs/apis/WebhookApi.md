# Sicoob.Pix.Api.WebhookApi

All URIs are relative to *https://api.sicoob.com.br/pix/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookChaveDelete**](WebhookApi.md#webhookchavedelete) | **DELETE** /webhook/{chave} | Cancelar o webhook Pix. |
| [**WebhookChaveGet**](WebhookApi.md#webhookchaveget) | **GET** /webhook/{chave} | Exibir informações acerca do Webhook Pix. |
| [**WebhookChavePut**](WebhookApi.md#webhookchaveput) | **PUT** /webhook/{chave} | Configurar o Webhook Pix. |
| [**WebhookGet**](WebhookApi.md#webhookget) | **GET** /webhook | Consultar webhooks cadastrados. |

<a id="webhookchavedelete"></a>
# **WebhookChaveDelete**
> void WebhookChaveDelete (string chave)

Cancelar o webhook Pix.

Endpoint para cancelamento do webhook. Não é a única forma pela qual um webhook pode ser removido.  O PSP recebedor está livre para remover unilateralmente um webhook que esteja associado a uma chave que não pertence mais a este usuário recebedor. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chave** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Webhook para notificações Pix foi cancelado. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookchaveget"></a>
# **WebhookChaveGet**
> WebhookCompleto WebhookChaveGet (string chave)

Exibir informações acerca do Webhook Pix.

Endpoint para recuperação de informações sobre o Webhook Pix. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chave** | **string** |  |  |

### Return type

[**WebhookCompleto**](WebhookCompleto.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dados do webhook. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookchaveput"></a>
# **WebhookChavePut**
> void WebhookChavePut (string chave, WebhookSolicitado webhookSolicitado)

Configurar o Webhook Pix.

Endpoint para configuração do serviço de notificações acerca de Pix recebidos. Somente Pix associados a um txid serão notificados. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chave** | **string** |  |  |
| **webhookSolicitado** | [**WebhookSolicitado**](WebhookSolicitado.md) |  |  |

### Return type

void (empty response body)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook para notificações acerca de Pix recebidos associados a um txid. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookget"></a>
# **WebhookGet**
> WebhooksConsultados WebhookGet (DateTime inicio = null, DateTime fim = null, int paginacaoPaginaAtual = null, int paginacaoItensPorPagina = null)

Consultar webhooks cadastrados.

Endpoint para consultar Webhooks cadastrados


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inicio** | **DateTime** |  | [optional]  |
| **fim** | **DateTime** |  | [optional]  |
| **paginacaoPaginaAtual** | **int** |  | [optional] [default to 0] |
| **paginacaoItensPorPagina** | **int** |  | [optional] [default to 100] |

### Return type

[**WebhooksConsultados**](WebhooksConsultados.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | lista dos locations cadastrados de acordo com o critério de busca. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

