# Sicoob.Pix.Api.PayloadLocationApi

All URIs are relative to *https://api.sicoob.com.br/pix/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LocGet**](PayloadLocationApi.md#locget) | **GET** /loc | Consultar locations cadastradas. |
| [**LocIdGet**](PayloadLocationApi.md#locidget) | **GET** /loc/{id} | Recuperar location do payload. |
| [**LocIdImagemGet**](PayloadLocationApi.md#locidimagemget) | **GET** /loc/{id}/imagem | Recuperar a imagem da location do payload. |
| [**LocIdTxidDelete**](PayloadLocationApi.md#locidtxiddelete) | **DELETE** /loc/{id}/txid | Desvincular uma cobrança de uma location. |
| [**LocPost**](PayloadLocationApi.md#locpost) | **POST** /loc | Criar location do payload. |

<a id="locget"></a>
# **LocGet**
> PayloadLocationConsultadas LocGet (DateTime inicio, DateTime fim, bool txIdPresente = null, string tipoCob = null, int paginacaoPaginaAtual = null, int paginacaoItensPorPagina = null)

Consultar locations cadastradas.

Endpoint para consultar locations cadastradas


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inicio** | **DateTime** |  |  |
| **fim** | **DateTime** |  |  |
| **txIdPresente** | **bool** |  | [optional]  |
| **tipoCob** | **string** |  | [optional]  |
| **paginacaoPaginaAtual** | **int** |  | [optional] [default to 0] |
| **paginacaoItensPorPagina** | **int** |  | [optional] [default to 100] |

### Return type

[**PayloadLocationConsultadas**](PayloadLocationConsultadas.md)

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

<a id="locidget"></a>
# **LocIdGet**
> PayloadLocationCompleta LocIdGet (decimal id)

Recuperar location do payload.

Recupera a location do payload


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **decimal** |  |  |

### Return type

[**PayloadLocationCompleta**](PayloadLocationCompleta.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dados da location do Payload. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="locidimagemget"></a>
# **LocIdImagemGet**
> System.IO.Stream LocIdImagemGet (decimal id, int largura = null)

Recuperar a imagem da location do payload.

Recupera a imagem da location do payload


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **decimal** |  |  |
| **largura** | **int** |  | [optional] [default to 360] |

### Return type

**System.IO.Stream**

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Imagem qrcode que representa a cobrança |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="locidtxiddelete"></a>
# **LocIdTxidDelete**
> PayloadLocation LocIdTxidDelete (string id)

Desvincular uma cobrança de uma location.

Endpoint utilizado para desvincular uma cobrança de uma location.  Se executado com sucesso, a entidade `loc` não apresentará mais um txid, se apresentava anteriormente à chamada. Adicionalmente, a entidade `cob` ou `cobv` associada ao txid desvinculado também passará a não mais apresentar um _location_. Esta operação não altera o `status` da `cob` ou `cobv` em questão. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**PayloadLocation**](PayloadLocation.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | cobrança representada pelo txid informado desvinculada com sucesso. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="locpost"></a>
# **LocPost**
> PayloadLocation LocPost (PayloadLocationSolicitada payloadLocationSolicitada)

Criar location do payload.

Criar location do payload


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payloadLocationSolicitada** | [**PayloadLocationSolicitada**](PayloadLocationSolicitada.md) | Dados para geração da location. |  |

### Return type

[**PayloadLocation**](PayloadLocation.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Dados da location do Payload. |  * location -  <br>  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

