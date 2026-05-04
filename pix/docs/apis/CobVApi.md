# Sicoob.Pix.Api.CobVApi

All URIs are relative to *https://api.sicoob.com.br/pix/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CobvGet**](CobVApi.md#cobvget) | **GET** /cobv | Consultar lista de cobranças com vencimento. |
| [**CobvTxidGet**](CobVApi.md#cobvtxidget) | **GET** /cobv/{txid} | Consultar cobrança com vencimento. |
| [**CobvTxidImagemGet**](CobVApi.md#cobvtxidimagemget) | **GET** /cobv/{txid}/imagem | Obtem a imagem qrcode de uma cobrança com vencimento. |
| [**CobvTxidPatch**](CobVApi.md#cobvtxidpatch) | **PATCH** /cobv/{txid} | Revisar cobrança com vencimento. |
| [**CobvTxidPut**](CobVApi.md#cobvtxidput) | **PUT** /cobv/{txid} | Criar cobrança com vencimento. |

<a id="cobvget"></a>
# **CobvGet**
> CobsVConsultadas CobvGet (DateTime inicio, DateTime fim, string cpf = null, string cnpj = null, bool locationPresente = null, string status = null, int loteCobVId = null, int paginacaoPaginaAtual = null, int paginacaoItensPorPagina = null)

Consultar lista de cobranças com vencimento.

Endpoint para consultar cobranças com vencimento através de parâmetros como início, fim, cpf, cnpj e status.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inicio** | **DateTime** |  |  |
| **fim** | **DateTime** |  |  |
| **cpf** | **string** |  | [optional]  |
| **cnpj** | **string** |  | [optional]  |
| **locationPresente** | **bool** |  | [optional]  |
| **status** | **string** |  | [optional]  |
| **loteCobVId** | **int** |  | [optional]  |
| **paginacaoPaginaAtual** | **int** |  | [optional] [default to 0] |
| **paginacaoItensPorPagina** | **int** |  | [optional] [default to 100] |

### Return type

[**CobsVConsultadas**](CobsVConsultadas.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lista de cobranças com vencimento. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobvtxidget"></a>
# **CobvTxidGet**
> CobVCompleta CobvTxidGet (string txid, int revisao = null)

Consultar cobrança com vencimento.

Endpoint para consultar uma cobrança com vencimento através de um determinado txid.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **revisao** | **int** |  | [optional]  |

### Return type

[**CobVCompleta**](CobVCompleta.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dados da cobrança com vencimento. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobvtxidimagemget"></a>
# **CobvTxidImagemGet**
> System.IO.Stream CobvTxidImagemGet (string txid, int revisao = null, int largura = null)

Obtem a imagem qrcode de uma cobrança com vencimento.

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

<a id="cobvtxidpatch"></a>
# **CobvTxidPatch**
> CobVGerada CobvTxidPatch (string txid, CobVRevisada cobVRevisada)

Revisar cobrança com vencimento.

Endpoint para revisar uma cobrança com vencimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **cobVRevisada** | [**CobVRevisada**](CobVRevisada.md) | Dados para geração da cobrança. |  |

### Return type

[**CobVGerada**](CobVGerada.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Cobrança com vencimento revisada. A revisão deve ser incrementada em 1. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cobvtxidput"></a>
# **CobvTxidPut**
> CobVGerada CobvTxidPut (string txid, CobVSolicitada cobVSolicitada)

Criar cobrança com vencimento.

Endpoint para criar uma cobrança com vencimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **txid** | **string** |  |  |
| **cobVSolicitada** | [**CobVSolicitada**](CobVSolicitada.md) | Dados para geração da cobrança com vencimento. |  |

### Return type

[**CobVGerada**](CobVGerada.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Cobrança com vencimento criada |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

