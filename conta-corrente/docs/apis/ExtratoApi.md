# Sicoob.ContaCorrente.Api.ExtratoApi

All URIs are relative to *https://api.sicoob.com.br/conta-corrente/v4*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ObterExtratoCompleto**](ExtratoApi.md#obterextratocompleto) | **GET** /extrato/{mes}/{ano} | Recupera o extrato de todas as transacoes ocorridas em uma conta corrente no devido mes, ano e dia agrupado de acordo com o tipo. |

<a id="obterextratocompleto"></a>
# **ObterExtratoCompleto**
> ExtratoSpuOpenBankingRestDTO ObterExtratoCompleto (string clientId, int mes, int ano, long numeroContaCorrente, int diaInicial = null, int diaFinal = null, bool agruparCNAB = null)

Recupera o extrato de todas as transacoes ocorridas em uma conta corrente no devido mes, ano e dia agrupado de acordo com o tipo.

Extrato bancario


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **mes** | **int** | Mes de referencia para o extrato. |  |
| **ano** | **int** | Ano de referencia para o extrato. |  |
| **numeroContaCorrente** | **long** | Numero da conta corrente. |  |
| **diaInicial** | **int** | Dia inicial para o extrato. | [optional]  |
| **diaFinal** | **int** | Dia final para o extrato. | [optional]  |
| **agruparCNAB** | **bool** | Agrupar movimento proveniente do CNAB | [optional]  |

### Return type

[**ExtratoSpuOpenBankingRestDTO**](ExtratoSpuOpenBankingRestDTO.md)

### Authorization

[oauth](../README.md#oauth), [client_id](../README.md#client_id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso |  -  |
| **400** | Ocorreu um erro negocial |  -  |
| **500** | Erro interno de servidor |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

