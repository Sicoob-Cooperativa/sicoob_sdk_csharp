# Sicoob.CobrancaV3.Api.NegativaoApi

All URIs are relative to *https://api.sicoob.com.br/cobranca-bancaria/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BoletosNossoNumeroNegativacoesDelete**](NegativaoApi.md#boletosnossonumeronegativacoesdelete) | **DELETE** /boletos/{nossoNumero}/negativacoes | Baixar a negativação de pagadores de boletos |
| [**BoletosNossoNumeroNegativacoesPatch**](NegativaoApi.md#boletosnossonumeronegativacoespatch) | **PATCH** /boletos/{nossoNumero}/negativacoes | Cancelar o apontamento da negativação de pagadores de boletos |
| [**BoletosNossoNumeroNegativacoesPost**](NegativaoApi.md#boletosnossonumeronegativacoespost) | **POST** /boletos/{nossoNumero}/negativacoes | Negativar pagadores de boletos |

<a id="boletosnossonumeronegativacoesdelete"></a>
# **BoletosNossoNumeroNegativacoesDelete**
> void BoletosNossoNumeroNegativacoesDelete (int nossoNumero, Negativacao boleto)

Baixar a negativação de pagadores de boletos

Serviço para comandar uma baixa da negativação de pagadores de boletos informados. Será enviado um pedido de baixa para o serviço de proteção ao crédito.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boleto** | [**Negativacao**](Negativacao.md) | Informações do boleto de cobrança. |  |

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

<a id="boletosnossonumeronegativacoespatch"></a>
# **BoletosNossoNumeroNegativacoesPatch**
> void BoletosNossoNumeroNegativacoesPatch (int nossoNumero, Negativacao boleto)

Cancelar o apontamento da negativação de pagadores de boletos

Serviço para cancelar o apontamento da negativação de pagadores de boletos informados. O boleto não será enviado ao serviço de proteção ao crédito.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boleto** | [**Negativacao**](Negativacao.md) | Informações do boleto. |  |

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

<a id="boletosnossonumeronegativacoespost"></a>
# **BoletosNossoNumeroNegativacoesPost**
> void BoletosNossoNumeroNegativacoesPost (int nossoNumero, Negativacao boletos)

Negativar pagadores de boletos

Serviço para indicar a negativação de pagadores de boletos informados. A negativação é o registro de pendências ou restrições nos órgãos de proteção ao crédito. No Sicoob, o parceiro para este serviço é o SERASA.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boletos** | [**Negativacao**](Negativacao.md) | Informações do boleto de cobrança. |  |

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

