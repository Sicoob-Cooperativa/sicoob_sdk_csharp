# Sicoob.CobrancaV3.Api.WebhookApi

All URIs are relative to *https://api.sicoob.com.br/cobranca-bancaria/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhooksGet**](WebhookApi.md#webhooksget) | **GET** /webhooks | Consultar os webhooks cadastrados. |
| [**WebhooksIdWebhookDelete**](WebhookApi.md#webhooksidwebhookdelete) | **DELETE** /webhooks/{idWebhook} | Excluir um webhook. |
| [**WebhooksIdWebhookPatch**](WebhookApi.md#webhooksidwebhookpatch) | **PATCH** /webhooks/{idWebhook} | Atualizar um webhook cadastrado. |
| [**WebhooksIdWebhookReativarPatch**](WebhookApi.md#webhooksidwebhookreativarpatch) | **PATCH** /webhooks/{idWebhook}/reativar | Reativar um webhook inativo. |
| [**WebhooksIdWebhookSolicitacoesGet**](WebhookApi.md#webhooksidwebhooksolicitacoesget) | **GET** /webhooks/{idWebhook}/solicitacoes | Consultar solicitações de um webhook. |
| [**WebhooksPost**](WebhookApi.md#webhookspost) | **POST** /webhooks | Cadastrar um webhook para receber notificações de acordo com o tipo de movimento. |

<a id="webhooksget"></a>
# **WebhooksGet**
> WebhooksGet200Response WebhooksGet (long idWebhook = null, int codigoTipoMovimento = null)

Consultar os webhooks cadastrados.

Serviço para consultar os detalhes dos webhooks cadastrados.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idWebhook** | **long** | Identificador único do webhook. | [optional]  |
| **codigoTipoMovimento** | **int** | Código do tipo de movimento do webhook.   7 - Pagamento (Baixa operacional)  | [optional]  |

### Return type

[**WebhooksGet200Response**](WebhooksGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso. |  -  |
| **204** | A consulta foi realizada com sucesso e não retornou registros. |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhooksidwebhookdelete"></a>
# **WebhooksIdWebhookDelete**
> void WebhooksIdWebhookDelete (long idWebhook)

Excluir um webhook.

Serviço responsável por remover permanentemente um webhook registrado, encerrando o envio de notificações para a URL vinculada.\" 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idWebhook** | **long** | Identificador único do webhook. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Webhook excluído com sucesso. |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhooksidwebhookpatch"></a>
# **WebhooksIdWebhookPatch**
> void WebhooksIdWebhookPatch (long idWebhook, WebhookAlteracao webhook)

Atualizar um webhook cadastrado.

Serviço de atualização de webhook. Ao modificar a URL, a situação do webhook será automaticamente alterada para '1 - Aguardando validação' e permanecerá assim até que a nova URL seja validada com sucesso. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idWebhook** | **long** | Identificador único do webhook. |  |
| **webhook** | [**WebhookAlteracao**](WebhookAlteracao.md) | Informações do webhook para atualização. |  |

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
| **204** | Webhook atualizado com sucesso. |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhooksidwebhookreativarpatch"></a>
# **WebhooksIdWebhookReativarPatch**
> void WebhooksIdWebhookReativarPatch (long idWebhook)

Reativar um webhook inativo.

Serviço de reativação de webhook desativado, restabelecendo o recebimento de notificações. A situação do webhook será atualizada para '1 - Aguardando validação' e permanecerá assim até que a URL seja validada com sucesso. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idWebhook** | **long** | Identificador único do webhook. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Webhook reativado com sucesso. |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhooksidwebhooksolicitacoesget"></a>
# **WebhooksIdWebhookSolicitacoesGet**
> WebhooksIdWebhookSolicitacoesGet200Response WebhooksIdWebhookSolicitacoesGet (long idWebhook, DateOnly dataSolicitacao, int pagina = null, int codigoSolicitacaoSituacao = null, string codigoBarras = null, long nossoNumero = null)

Consultar solicitações de um webhook.

Consulta as solicitações de notificação para um webhook com base na data de solicitação informada.  Retorna o histórico das tentativas de notificação, incluindo o status e a resposta da requisição. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idWebhook** | **long** | Identificador único do webhook. |  |
| **dataSolicitacao** | **DateOnly** | Data da solicitação. Formato: yyyy-MM-dd |  |
| **pagina** | **int** | Número da página a ser consultada. | [optional]  |
| **codigoSolicitacaoSituacao** | **int** | Código da situação da solicitação do webhook.   - 2 - Aguardando envio   - 3 - Enviado com sucesso   - 6 - Erro no envio  | [optional]  |
| **codigoBarras** | **string** | Código de barras do boleto presente na notificação webhook | [optional]  |
| **nossoNumero** | **long** | Nosso número do boleto presente na notificação webhook | [optional]  |

### Return type

[**WebhooksIdWebhookSolicitacoesGet200Response**](WebhooksIdWebhookSolicitacoesGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso. |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookspost"></a>
# **WebhooksPost**
> WebhooksPost201Response WebhooksPost (WebhookCadastro webhook)

Cadastrar um webhook para receber notificações de acordo com o tipo de movimento.

Este serviço permite cadastrar uma URL que será notificada sempre que ocorrer um evento associado a um tipo de movimento. O webhook pode ser configurado para o período de movimentação atual (D0). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhook** | [**WebhookCadastro**](WebhookCadastro.md) | Informações do webhook para o cadastro. |  |

### Return type

[**WebhooksPost201Response**](WebhooksPost201Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Webhook cadastrado com sucesso. |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

