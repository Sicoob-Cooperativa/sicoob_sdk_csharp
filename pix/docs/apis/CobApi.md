# Sicoob.Pix.Api.CobApi

All URIs are relative to *https://api.sicoob.com.br/pix/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CobGet**](CobApi.md#cobget) | **GET** /cob | Consultar lista de cobranças imediatas. |
| [**CobPost**](CobApi.md#cobpost) | **POST** /cob | Criar cobrança imediata. |
| [**CobTxidGet**](CobApi.md#cobtxidget) | **GET** /cob/{txid} | Consultar cobrança imediata. |
| [**CobTxidImagemGet**](CobApi.md#cobtxidimagemget) | **GET** /cob/{txid}/imagem | Obtem a imagem qrcode de uma cobrança imediata. |
| [**CobTxidPatch**](CobApi.md#cobtxidpatch) | **PATCH** /cob/{txid} | Revisar cobrança imediata. |
| [**CobTxidPut**](CobApi.md#cobtxidput) | **PUT** /cob/{txid} | Criar cobrança imediata. |

<a id="cobget"></a>
# **CobGet**
> CobsConsultadas CobGet (DateTime inicio, DateTime fim, string cpf = null, string cnpj = null, bool locationPresente = null, string status = null, int paginacaoPaginaAtual = null, int paginacaoItensPorPagina = null)

Consultar lista de cobranças imediatas.

Endpoint para consultar cobranças imediatas através de parâmetros como início, fim, cpf, cnpj e status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inicio** | **DateTime** |  |  |
| **fim** | **DateTime** |  |  |
| **cpf** | **string** |  | [optional]  |
| **cnpj** | **string** |  | [optional]  |
| **locationPresente** | **bool** |  | [optional]  |
| **status** | **string** |  | [optional]  |
| **paginacaoPaginaAtual** | **int** |  | [optional] [default to 0] |
| **paginacaoItensPorPagina** | **int** |  | [optional] [default to 100] |

### Return type

[**CobsConsultadas**](CobsConsultadas.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lista de cobranças imediatas. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobpost"></a>
# **CobPost**
> CobGerada CobPost (CobSolicitada cobSolicitada)

Criar cobrança imediata.

Endpoint para criar uma cobrança imediata, neste caso, o txid deve ser definido pelo PSP.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cobSolicitada** | [**CobSolicitada**](CobSolicitada.md) | Dados para geração da cobrança imediata. |  |

### Return type

[**CobGerada**](CobGerada.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Cobrança imediata criada |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobtxidget"></a>
# **CobTxidGet**
> CobCompleta CobTxidGet (string txid, int revisao = null)

Consultar cobrança imediata.

Endpoint para consultar uma cobrança através de um determinado txid.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **revisao** | **int** |  | [optional]  |

### Return type

[**CobCompleta**](CobCompleta.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dados da cobrança imediata. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobtxidimagemget"></a>
# **CobTxidImagemGet**
> System.IO.Stream CobTxidImagemGet (string txid, int revisao = null, int largura = null)

Obtem a imagem qrcode de uma cobrança imediata.

Endpoint para gerar a imagem qrcode de uma cobrança através de um determinado txid.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **revisao** | **int** |  | [optional]  |
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

<a id="cobtxidpatch"></a>
# **CobTxidPatch**
> CobGerada CobTxidPatch (string txid, CobRevisada cobRevisada)

Revisar cobrança imediata.

Endpoint para revisar uma cobrança imediata.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **cobRevisada** | [**CobRevisada**](CobRevisada.md) | Dados para geração da cobrança. |  |

### Return type

[**CobGerada**](CobGerada.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cobrança imediata revisada. A revisão deve ser incrementada em 1. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobtxidput"></a>
# **CobTxidPut**
> CobGerada CobTxidPut (string txid, CobSolicitada cobSolicitada)

Criar cobrança imediata.

Endpoint para criar uma cobrança imediata.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **cobSolicitada** | [**CobSolicitada**](CobSolicitada.md) | Dados para geração da cobrança imediata. |  |

### Return type

[**CobGerada**](CobGerada.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Cobrança imediata criada |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

