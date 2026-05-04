# Sicoob.PagamentosPix.Api.APIDePagamentosPIXApi

All URIs are relative to *https://api.sicoob.com.br/pix-pagamentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PagamentosConfirmacaoPost**](APIDePagamentosPIXApi.md#pagamentosconfirmacaopost) | **POST** /pagamentos/confirmacao | Efetivar um pagamento iniciado pela API de pagamentos |
| [**PagamentosIdGet**](APIDePagamentosPIXApi.md#pagamentosidget) | **GET** /pagamentos/{id} | Consultar pagamento pix através do endToEndId. |
| [**PagamentosPost**](APIDePagamentosPIXApi.md#pagamentospost) | **POST** /pagamentos | Iniciar pagamento por meio de chave DICT |
| [**PagamentosQrcodePost**](APIDePagamentosPIXApi.md#pagamentosqrcodepost) | **POST** /pagamentos/qrcode | Realizar pagamento por meio de código QRCode |
| [**PagamentosWebhookDelete**](APIDePagamentosPIXApi.md#pagamentoswebhookdelete) | **DELETE** /pagamentos/webhook | Cancelar o webhook Pix. |
| [**PagamentosWebhookGet**](APIDePagamentosPIXApi.md#pagamentoswebhookget) | **GET** /pagamentos/webhook | Exibir informações acerca do Webhook Pix. |
| [**PagamentosWebhookPut**](APIDePagamentosPIXApi.md#pagamentoswebhookput) | **PUT** /pagamentos/webhook | Configurar o Webhook Pix. |

<a id="pagamentosconfirmacaopost"></a>
# **PagamentosConfirmacaoPost**
> RetornoPagamento PagamentosConfirmacaoPost (RequisicaoLancamentoEfetivacao requisicaoLancamentoEfetivacao)

Efetivar um pagamento iniciado pela API de pagamentos

Efetivar um pagamento iniciado pela API de pagamentos


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requisicaoLancamentoEfetivacao** | [**RequisicaoLancamentoEfetivacao**](RequisicaoLancamentoEfetivacao.md) | Objeto que contem um lancamento a ser efetivado |  |

### Return type

[**RetornoPagamento**](RetornoPagamento.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pagamento foi criado com sucesso. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pagamentosidget"></a>
# **PagamentosIdGet**
> RetornoPagamento PagamentosIdGet (string id)

Consultar pagamento pix através do endToEndId.

Endpoint para consultar um pagamento Pix através de um e2eid.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**RetornoPagamento**](RetornoPagamento.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dados do Pix efetuado. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pagamentospost"></a>
# **PagamentosPost**
> PagamentoIniciadoDict PagamentosPost (RequisicaoLancamentoIniciacao requisicaoLancamentoIniciacao)

Iniciar pagamento por meio de chave DICT

Iniciar pagamento por meio de chave DICT


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requisicaoLancamentoIniciacao** | [**RequisicaoLancamentoIniciacao**](RequisicaoLancamentoIniciacao.md) | Objeto que contem um lancamento a ser efetivado |  |

### Return type

[**PagamentoIniciadoDict**](PagamentoIniciadoDict.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pagamento iniciciado com sucesso. |  -  |
| **400** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pagamentosqrcodepost"></a>
# **PagamentosQrcodePost**
> PagamentoIniciadoQRCodeResponse PagamentosQrcodePost (PagamentoIniciadoQRCodeBody pagamentoIniciadoQRCodeBody)

Realizar pagamento por meio de código QRCode

Realiza o pagamento de Pix Copia e Cola (Imediato ou Vencimento) com execução direta. O processamento dispensa confirmação adicional ao validar automaticamente se:   1. O valor original coincide com o valor decodificado (sem juros/multa ou desconto).   2. A aplicação de juros/multa está autorizada.   3. O CNPJ do favorecido é idêntico ao registrado no payload. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagamentoIniciadoQRCodeBody** | [**PagamentoIniciadoQRCodeBody**](PagamentoIniciadoQRCodeBody.md) | Objeto que contém pagamento via QRCode |  |

### Return type

[**PagamentoIniciadoQRCodeResponse**](PagamentoIniciadoQRCodeResponse.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pagamento Iniciado com QRCode |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pagamentoswebhookdelete"></a>
# **PagamentosWebhookDelete**
> void PagamentosWebhookDelete ()

Cancelar o webhook Pix.

Endpoint para cancelamento do webhook. Não é a única forma pela qual um webhook pode ser removido.  O PSP recebedor está livre para remover unilateralmente um webhook que esteja associado a uma chave que não pertence mais a este usuário recebedor. 


### Parameters
This endpoint does not need any parameter.
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

<a id="pagamentoswebhookget"></a>
# **PagamentosWebhookGet**
> WebhookCompleto PagamentosWebhookGet ()

Exibir informações acerca do Webhook Pix.

Endpoint para recuperação de informações sobre o Webhook Pix. 


### Parameters
This endpoint does not need any parameter.
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

<a id="pagamentoswebhookput"></a>
# **PagamentosWebhookPut**
> void PagamentosWebhookPut (WebhookSolicitado webhookSolicitado)

Configurar o Webhook Pix.

Endpoint para configuração do serviço de notificações acerca de Pix enviados. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **200** | Webhook para notificações acerca de Pix enviados. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

