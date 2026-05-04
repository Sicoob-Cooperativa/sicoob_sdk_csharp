# Sicoob.Investimentos.Api.InvestimentosApi

All URIs are relative to *https://api.sicoob.com.br/investimentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RendaFixaCarteirasGet**](InvestimentosApi.md#rendafixacarteirasget) | **GET** /renda-fixa/carteiras | Busca os investimentos do cliente sumarizados por carteira |
| [**RendaFixaCarteirasIdCarteiraModalidadesGet**](InvestimentosApi.md#rendafixacarteirasidcarteiramodalidadesget) | **GET** /renda-fixa/carteiras/{idCarteira}/modalidades | Busca os investimentos do cliente pela carteira |
| [**RendaFixaCarteirasIdCarteiraModalidadesIdModalidadeAplicacoesGet**](InvestimentosApi.md#rendafixacarteirasidcarteiramodalidadesidmodalidadeaplicacoesget) | **GET** /renda-fixa/carteiras/{idCarteira}/modalidades/{idModalidade}/aplicacoes | Busca os dados da aplicação pela carteira e modalidade passadas |
| [**RendaFixaExtratoNumeroContaCorrenteIdAplicacaoIdModalidadeGet**](InvestimentosApi.md#rendafixaextratonumerocontacorrenteidaplicacaoidmodalidadeget) | **GET** /renda-fixa/extrato/{numeroContaCorrente}/{idAplicacao}/{idModalidade} | Busca o extrato da aplicação pela modalidade, data, conta e aplicação passadas |
| [**RendaFixaSaldosGet**](InvestimentosApi.md#rendafixasaldosget) | **GET** /renda-fixa/saldos | Busca os investimentos do cliente |

<a id="rendafixacarteirasget"></a>
# **RendaFixaCarteirasGet**
> RendaFixaCarteirasGet200Response RendaFixaCarteirasGet (string clientId, int numeroCooperativa, int numeroContaCorrente)

Busca os investimentos do cliente sumarizados por carteira

Retorna sumarizado todos os investimentos LCA, RDC e DAP do cliente separado por carteira


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **numeroCooperativa** | **int** | Número da Cooperativa. |  |
| **numeroContaCorrente** | **int** | Número da Conta Corrente. |  |

### Return type

[**RendaFixaCarteirasGet200Response**](RendaFixaCarteirasGet200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Carteiras encontradas |  -  |
| **400** | Carteiras não encontradas |  -  |
| **500** | Carteiras não encontradas |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rendafixacarteirasidcarteiramodalidadesget"></a>
# **RendaFixaCarteirasIdCarteiraModalidadesGet**
> RendaFixaCarteirasIdCarteiraModalidadesGet200Response RendaFixaCarteirasIdCarteiraModalidadesGet (string clientId, int numeroCooperativa, int numeroContaCorrente, int idCarteira)

Busca os investimentos do cliente pela carteira

Retorna todos os investimentos de uma determinada carteira do cliente


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **numeroCooperativa** | **int** | Número da Cooperativa. |  |
| **numeroContaCorrente** | **int** | Número da Conta Corrente. |  |
| **idCarteira** | **int** | ID da carteira |  |

### Return type

[**RendaFixaCarteirasIdCarteiraModalidadesGet200Response**](RendaFixaCarteirasIdCarteiraModalidadesGet200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Investimentos da carteira encontrados |  -  |
| **400** | Investimentos da Carteiras não encontradas |  -  |
| **500** | Investimentos da Carteiras não encontradas |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rendafixacarteirasidcarteiramodalidadesidmodalidadeaplicacoesget"></a>
# **RendaFixaCarteirasIdCarteiraModalidadesIdModalidadeAplicacoesGet**
> RendaFixaCarteirasIdCarteiraModalidadesIdModalidadeAplicacoesGet200Response RendaFixaCarteirasIdCarteiraModalidadesIdModalidadeAplicacoesGet (string clientId, int numeroCooperativa, int numeroContaCorrente, int idCarteira, int idModalidade)

Busca os dados da aplicação pela carteira e modalidade passadas

Retorna todas as aplicações de uma determinada carteira e modalidade do cliente


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **numeroCooperativa** | **int** | Número da Cooperativa. |  |
| **numeroContaCorrente** | **int** | Número da Conta Corrente. |  |
| **idCarteira** | **int** | ID da carteira |  |
| **idModalidade** | **int** | ID da modalidade |  |

### Return type

[**RendaFixaCarteirasIdCarteiraModalidadesIdModalidadeAplicacoesGet200Response**](RendaFixaCarteirasIdCarteiraModalidadesIdModalidadeAplicacoesGet200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Aplicações da modalidade encontradas |  -  |
| **400** | Aplicações da modalidade não encontradas |  -  |
| **500** | Aplicações da modalidade não encontradas |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rendafixaextratonumerocontacorrenteidaplicacaoidmodalidadeget"></a>
# **RendaFixaExtratoNumeroContaCorrenteIdAplicacaoIdModalidadeGet**
> RendaFixaExtratoNumeroContaCorrenteIdAplicacaoIdModalidadeGet200Response RendaFixaExtratoNumeroContaCorrenteIdAplicacaoIdModalidadeGet (string clientId, int numeroCooperativa, int numeroContaCorrente, int idModalidade, int idAplicacao, string dataLote)

Busca o extrato da aplicação pela modalidade, data, conta e aplicação passadas

Retorna o extrato da aplicação


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **numeroCooperativa** | **int** | Número da Cooperativa. |  |
| **numeroContaCorrente** | **int** | Número da Conta Corrente. |  |
| **idModalidade** | **int** | ID da modalidade |  |
| **idAplicacao** | **int** | ID da aplicação |  |
| **dataLote** | **string** | Data do lote |  |

### Return type

[**RendaFixaExtratoNumeroContaCorrenteIdAplicacaoIdModalidadeGet200Response**](RendaFixaExtratoNumeroContaCorrenteIdAplicacaoIdModalidadeGet200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Extrato da aplicação encontrada |  -  |
| **204** | Aplicações da modalidade não encontradas |  -  |
| **400** | Erro negocial |  -  |
| **500** | Erro interno do servidor |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rendafixasaldosget"></a>
# **RendaFixaSaldosGet**
> RendaFixaSaldosGet200Response RendaFixaSaldosGet (string clientId, int numeroCooperativa, int numeroContaCorrente)

Busca os investimentos do cliente

Retorna sumarizado todos os investimentos LCA, RDC e DAP do cliente juntos.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **numeroCooperativa** | **int** | Número da Cooperativa. |  |
| **numeroContaCorrente** | **int** | Número da Conta Corrente. |  |

### Return type

[**RendaFixaSaldosGet200Response**](RendaFixaSaldosGet200Response.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Aplicações encontradas |  -  |
| **400** | Aplicações não encontradas |  -  |
| **500** | Aplicações não encontradas |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

