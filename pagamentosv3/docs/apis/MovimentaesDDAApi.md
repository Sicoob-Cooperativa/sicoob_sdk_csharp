# Sicoob.PagamentosV3.Api.MovimentaesDDAApi

All URIs are relative to *https://api.sicoob.com.br/pagamentos/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BoletosGet**](MovimentaesDDAApi.md#boletosget) | **GET** /boletos | Consultar Boletos DDA |

<a id="boletosget"></a>
# **BoletosGet**
> List&lt;BoletoDDA&gt; BoletosGet (string clientId, long numeroConta, DateOnly dataInicial, DateOnly dataFinal, long situacao, int tipoData)

Consultar Boletos DDA

Serviço para consultar boletos DDA de uma conta corrente.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **numeroConta** | **long** | Número da Conta Habilitada para Pagamentos via API. |  |
| **dataInicial** | **DateOnly** | Data inicial do filtro por data. Formato: yyyy-MM-dd Exemplo: 2022-07-30  |  |
| **dataFinal** | **DateOnly** | Data final do filtro por data. Formato: yyyy-MM-dd Exemplo: 2022-07-30  |  |
| **situacao** | **long** | Código da Situação do Boleto. - 1 - Em aberto - 2 - Agendado - 3 - Liquidado - 4 - Baixado |  |
| **tipoData** | **int** | Opções 1, 2 ou 3 para escolher a data que será filtrada.  - 1 - Data de vencimento - 2 - Data de emissão - 3 - Data de inclusão |  |

### Return type

[**List&lt;BoletoDDA&gt;**](BoletoDDA.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **204** | Requisição processada com sucesso e não há conteúdo a ser retornado. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

