# Sicoob.Pix.Api.PixApi

All URIs are relative to *https://api.sicoob.com.br/pix/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PixE2eidDevolucaoIdGet**](PixApi.md#pixe2eiddevolucaoidget) | **GET** /pix/{e2eid}/devolucao/{id} | Consultar devolução. |
| [**PixE2eidDevolucaoIdPut**](PixApi.md#pixe2eiddevolucaoidput) | **PUT** /pix/{e2eid}/devolucao/{id} | Solicitar devolução. |
| [**PixE2eidGet**](PixApi.md#pixe2eidget) | **GET** /pix/{e2eid} | Consultar Pix. |
| [**PixGet**](PixApi.md#pixget) | **GET** /pix | Consultar Pix recebidos. |

<a id="pixe2eiddevolucaoidget"></a>
# **PixE2eidDevolucaoIdGet**
> Devolucao PixE2eidDevolucaoIdGet (string e2eid, string id)

Consultar devolução.

Endpoint para consultar uma devolução através de um End To End ID do Pix e do ID da devolução


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **e2eid** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**Devolucao**](Devolucao.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dados da devolução. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pixe2eiddevolucaoidput"></a>
# **PixE2eidDevolucaoIdPut**
> Devolucao PixE2eidDevolucaoIdPut (string e2eid, string id, DevolucaoSolicitada devolucaoSolicitada)

Solicitar devolução.

Endpoint para solicitar uma devolução através de um e2eid do Pix e do ID da devolução. O motivo que será atribuído à PACS.004 será \"MD06\" ou \"SL02\" de acordo com a aba RTReason da PACS.004 que consta no Catálogo de Mensagens do Pix a depender da `natureza` da devolução (Vide a descrição deste campo). 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **e2eid** | **string** |  |  |
| **id** | **string** |  |  |
| **devolucaoSolicitada** | [**DevolucaoSolicitada**](DevolucaoSolicitada.md) | Dados para pedido de devolução. |  |

### Return type

[**Devolucao**](Devolucao.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Dados da devolução. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pixe2eidget"></a>
# **PixE2eidGet**
> Pix PixE2eidGet (string e2eid)

Consultar Pix.

Endpoint para consultar um Pix através de um e2eid.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **e2eid** | **string** |  |  |

### Return type

[**Pix**](Pix.md)

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

<a id="pixget"></a>
# **PixGet**
> PixConsultados PixGet (DateTime inicio, DateTime fim, string txid = null, bool txIdPresente = null, bool devolucaoPresente = null, string cpf = null, string cnpj = null, int paginacaoPaginaAtual = null, int paginacaoItensPorPagina = null)

Consultar Pix recebidos.

Endpoint para consultar Pix recebidos


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inicio** | **DateTime** |  |  |
| **fim** | **DateTime** |  |  |
| **txid** | [**string**](string.md) |  | [optional]  |
| **txIdPresente** | **bool** |  | [optional]  |
| **devolucaoPresente** | **bool** |  | [optional]  |
| **cpf** | **string** |  | [optional]  |
| **cnpj** | **string** |  | [optional]  |
| **paginacaoPaginaAtual** | **int** |  | [optional] [default to 0] |
| **paginacaoItensPorPagina** | **int** |  | [optional] [default to 100] |

### Return type

[**PixConsultados**](PixConsultados.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | lista dos Pix recebidos de acordo com o critério de busca. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

