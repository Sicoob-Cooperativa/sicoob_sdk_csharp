# Sicoob.CobrancaV3.Api.ProtestoApi

All URIs are relative to *https://api.sicoob.com.br/cobranca-bancaria/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BoletosNossoNumeroProtestosDelete**](ProtestoApi.md#boletosnossonumeroprotestosdelete) | **DELETE** /boletos/{nossoNumero}/protestos | Desistir do protesto de boletos |
| [**BoletosNossoNumeroProtestosPatch**](ProtestoApi.md#boletosnossonumeroprotestospatch) | **PATCH** /boletos/{nossoNumero}/protestos | Cancelar o apontamento de protesto de boletos |
| [**BoletosNossoNumeroProtestosPost**](ProtestoApi.md#boletosnossonumeroprotestospost) | **POST** /boletos/{nossoNumero}/protestos | Protestar boletos |

<a id="boletosnossonumeroprotestosdelete"></a>
# **BoletosNossoNumeroProtestosDelete**
> void BoletosNossoNumeroProtestosDelete (int nossoNumero, Protesto boleto)

Desistir do protesto de boletos

Este serviço realiza o pedido de desistência do protesto de boletos informados. O pedido de desistência não garante que o protesto será retirado. Deve-se aguardar o retorno do cartório. O pedido de desistência pode ser realizado a qualquer momento, desde que haja um apontamento prévio.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boleto** | [**Protesto**](Protesto.md) | Informações do boleto de cobrança. |  |

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

<a id="boletosnossonumeroprotestospatch"></a>
# **BoletosNossoNumeroProtestosPatch**
> void BoletosNossoNumeroProtestosPatch (int nossoNumero, Protesto boleto)

Cancelar o apontamento de protesto de boletos

Este serviço realiza a indicação de cancelamento de protesto de boletos informados. Os boletos em atraso e não pagos podem ser indicados a protesto. Caso seja realizado no mesmo dia, pode-se cancelar o apontamento a protesto.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boleto** | [**Protesto**](Protesto.md) | Informações do boleto bancário. |  |

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

<a id="boletosnossonumeroprotestospost"></a>
# **BoletosNossoNumeroProtestosPost**
> void BoletosNossoNumeroProtestosPost (int nossoNumero, Protesto boletos)

Protestar boletos

Este serviço registra a indicação a protesto de boletos informados. Os boletos vencidos e não pagos podem ser protestados e registrados em cartório.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boletos** | [**Protesto**](Protesto.md) | Informações do boleto bancário. |  |

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

