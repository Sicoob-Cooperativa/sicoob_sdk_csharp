# Sicoob.SpbTransferencias.Api.TEDsApi

All URIs are relative to *https://api.sicoob.com.br/spb/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TransferenciasAgendamentosIdAgendamentoDelete**](TEDsApi.md#transferenciasagendamentosidagendamentodelete) | **DELETE** /transferencias/agendamentos/{idAgendamento} | Cancela uma TED com o status de agendada. |
| [**TransferenciasCodigoGet**](TEDsApi.md#transferenciascodigoget) | **GET** /transferencias/{codigo} | Consulta TED pelo atributo numeroControleIf. |
| [**TransferenciasPost**](TEDsApi.md#transferenciaspost) | **POST** /transferencias | Envio de TED entre clientes. |

<a id="transferenciasagendamentosidagendamentodelete"></a>
# **TransferenciasAgendamentosIdAgendamentoDelete**
> TransferenciasAgendamentosIdAgendamentoDelete200Response TransferenciasAgendamentosIdAgendamentoDelete (string clientId, int idAgendamento, string xIdempotencyKey, string idToken)

Cancela uma TED com o status de agendada.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **idAgendamento** | **int** | O codigo corresponde ao idAgendamento. |  |
| **xIdempotencyKey** | **string** | Codigo de controle idpotencia UUIDV4, deve ser unico para cada requisição. | [default to &quot;657e23a0-d14c-481e-a11c-3c718ff5b3c0&quot;] |
| **idToken** | **string** | Token JWT(id_token) gerado na autenticação. | [default to &quot;xxxx-xxxx-xxxx&quot;] |

### Return type

[**TransferenciasAgendamentosIdAgendamentoDelete200Response**](TransferenciasAgendamentosIdAgendamentoDelete200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TED encontrada. |  -  |
| **404** | TED não encontrada. |  -  |
| **500** | Ocorreu um erro no servidor. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transferenciascodigoget"></a>
# **TransferenciasCodigoGet**
> TransferenciasCodigoGet200Response TransferenciasCodigoGet (string clientId, string codigo, string idToken)

Consulta TED pelo atributo numeroControleIf.

Retorna as informações de uma TED.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **codigo** | **string** | O codigo corresponde ao numeroControleIf. |  |
| **idToken** | **string** | Token JWT(id_token) gerado na autenticação. | [default to &quot;xxxx-xxxx-xxxx&quot;] |

### Return type

[**TransferenciasCodigoGet200Response**](TransferenciasCodigoGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TED encontrada. |  -  |
| **404** | TED não encontrada. |  -  |
| **500** | Ocorreu um erro no servidor. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transferenciaspost"></a>
# **TransferenciasPost**
> PaymentTransactionRetorno TransferenciasPost (string clientId, PaymentTransaction transferencia, string xIdempotencyKey, string idToken)

Envio de TED entre clientes.

Envio de TED entre clientes.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **transferencia** | [**PaymentTransaction**](PaymentTransaction.md) | Objeto contendo dados para realização do agendamento de pagamento de convênio. |  |
| **xIdempotencyKey** | **string** | Codigo de controle idpotencia no padrão UUIDV4, deve ser unico para cada requisição. | [default to &quot;657e23a0-d14c-481e-a11c-3c718ff5b3c0&quot;] |
| **idToken** | **string** | Token JWT(id_token) gerado na autenticação. | [default to &quot;xxxx-xxxx-xxxx&quot;] |

### Return type

[**PaymentTransactionRetorno**](PaymentTransactionRetorno.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | TED enviada. |  -  |
| **404** | Não foi possivel o envio da TED. |  -  |
| **500** | Ocorreu um erro no servidor. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

