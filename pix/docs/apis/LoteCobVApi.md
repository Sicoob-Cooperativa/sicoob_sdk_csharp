# Sicoob.Pix.Api.LoteCobVApi

All URIs are relative to *https://api.sicoob.com.br/pix/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LotecobvGet**](LoteCobVApi.md#lotecobvget) | **GET** /lotecobv | Consultar lotes de cobranças com vencimento. |
| [**LotecobvIdGet**](LoteCobVApi.md#lotecobvidget) | **GET** /lotecobv/{id} | Consultar um lote específico de cobranças com vencimento. |
| [**LotecobvIdPatch**](LoteCobVApi.md#lotecobvidpatch) | **PATCH** /lotecobv/{id} | Utilizado para revisar cobranças específicas dentro de um lote de cobranças com vencimento. |
| [**LotecobvIdPut**](LoteCobVApi.md#lotecobvidput) | **PUT** /lotecobv/{id} | Criar/Alterar lote de cobranças com vencimento. |

<a id="lotecobvget"></a>
# **LotecobvGet**
> LotesCobVConsultados LotecobvGet (DateTime inicio, DateTime fim, int paginacaoPaginaAtual = null, int paginacaoItensPorPagina = null)

Consultar lotes de cobranças com vencimento.

Endpoint para consultar lista de lotes de cobranças com vencimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inicio** | **DateTime** |  |  |
| **fim** | **DateTime** |  |  |
| **paginacaoPaginaAtual** | **int** |  | [optional] [default to 0] |
| **paginacaoItensPorPagina** | **int** |  | [optional] [default to 100] |

### Return type

[**LotesCobVConsultados**](LotesCobVConsultados.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lotes de cobranças com vencimento. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="lotecobvidget"></a>
# **LotecobvIdGet**
> LoteCobVConsultado LotecobvIdGet (string id)

Consultar um lote específico de cobranças com vencimento.

Endpoint para consultar um lote de cobranças com vencimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**LoteCobVConsultado**](LoteCobVConsultado.md)

### Authorization

[oauth-mtls-sso](../README.md#oauth-mtls-sso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lote de cobranças com vencimento. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="lotecobvidpatch"></a>
# **LotecobvIdPatch**
> void LotecobvIdPatch (string id, LotecobvIdPatchRequest lotecobvIdPatchRequest)

Utilizado para revisar cobranças específicas dentro de um lote de cobranças com vencimento.

Endpoint utilizado para revisar cobranças específicas dentro de um lote de cobranças com vencimento.   A diferença deste endpoint para o endpoint PUT correlato é que este endpoint admite um array `cobsv` com menos solicitações de criação ou alteração de cobranças do que o array atribuído na requisição originária do lote.  Não se pode, entretanto, utilizar esse endpoint para agregar ou remover solicitações de alteração ou criação de cobranças conforme constam na requisição originária do lote.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **lotecobvIdPatchRequest** | [**LotecobvIdPatchRequest**](LotecobvIdPatchRequest.md) | Dados para geração de lote de cobranças com vencimento. |  |

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
| **202** | Solicitação de revisão do Lote de cobranças encaminhada para processamento. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="lotecobvidput"></a>
# **LotecobvIdPut**
> void LotecobvIdPut (string id, LotecobvIdPutRequest lotecobvIdPutRequest)

Criar/Alterar lote de cobranças com vencimento.

Endpoint utilizado para criar ou alterar um lote de cobranças com vencimento.  Para o caso de uso de alteração de cobranças, o array a ser atribuído na requisicão deve ser composto pelas exatas requisições de criação de cobranças que constaram no array atribuído na requisição originária.  Não se pode utilizar este endpoint para _alterar_ um lote de cobranças com vencimento agregando ou removendo cobranças já existentes dentro do conjunto de cobranças criadas na requisição originária do lote.  Em outras palavras, se originalmente criou-se um lote, por exemplo, com as cobranças [`a`, `b` e `c`], não se pode _alterar_ esse conjunto de cobranças original que o lote representa para [`a`, `b`, `c`, `d`], ou para [`a`, `b`]. Por outro lado, pode-se alterar, _em lote_ as cobranças [`a`, `b`, `c`], conforme originalmente constam na requisição originária do lote.  Uma solicitação de __criação__ de cobrança com status \"EM_PROCESSAMENTO\" ou \"NEGADA\" está associada a uma cobrança não _existe_ de fato, portanto não será listada em `GET /cobv` ou `GET /cobv/{txid}`.  Uma cobrança, uma vez criada via `PUT /cobv/{txid}`, não pode ser associada a um lote posteriormente.  Uma cobrança, uma vez criada via `PUT /lotecobv/{id}`, não pode ser associada a um novo lote posteriormente.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **lotecobvIdPutRequest** | [**LotecobvIdPutRequest**](LotecobvIdPutRequest.md) | Dados para geração de lote de cobranças com vencimento. |  |

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
| **202** | Lote de cobranças com vencimento solicitado para criação. |  -  |
| **400** | Requisição com formato inválido. |  -  |
| **403** | Requisição de participante autenticado que viola alguma regra de autorização. |  -  |
| **404** | Recurso solicitado não foi encontrado. |  -  |
| **503** | Serviço não está disponível no momento. Serviço solicitado pode estar em manutenção ou fora da janela de funcionamento. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

