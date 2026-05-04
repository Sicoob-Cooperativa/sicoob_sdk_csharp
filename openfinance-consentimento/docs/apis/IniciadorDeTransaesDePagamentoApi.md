# Sicoob.OpenFinance.Api.IniciadorDeTransaesDePagamentoApi

All URIs are relative to *https://api.sicoob.com.br/payments/v2/itp*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuscarConsentimentoExternoIniciadoraUsingGET**](IniciadorDeTransaesDePagamentoApi.md#buscarconsentimentoexternoiniciadorausingget) | **GET** /consents/{consent-id} | Buscar consentimento de pagamento. |
| [**CriarConsentimentoUsingPOST1**](IniciadorDeTransaesDePagamentoApi.md#criarconsentimentousingpost1) | **POST** /consents | Criar consentimento para a iniciação de pagamento. |
| [**ListarUsingGET3**](IniciadorDeTransaesDePagamentoApi.md#listarusingget3) | **GET** /consents | Listar consentimento de pagamento. |
| [**RetornoAutorizacaoUsingPOST1**](IniciadorDeTransaesDePagamentoApi.md#retornoautorizacaousingpost1) | **PUT** /consents/callback | Atualizar consentimento de pagamento callback |

<a id="buscarconsentimentoexternoiniciadorausingget"></a>
# **BuscarConsentimentoExternoIniciadoraUsingGET**
> ConsentimentoPagamentoIniciacao BuscarConsentimentoExternoIniciadoraUsingGET (string cpf, string consentId, string clientId, string cnpj = null)

Buscar consentimento de pagamento.

Operação para buscar o consentimento de pagamento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cpf** | **string** | cpf |  |
| **consentId** | **string** | Identificador do consentimento |  |
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |
| **cnpj** | **string** | cnpj | [optional]  |

### Return type

[**ConsentimentoPagamentoIniciacao**](ConsentimentoPagamentoIniciacao.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Informações recuperadas com sucesso |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Dados não encontrados |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="criarconsentimentousingpost1"></a>
# **CriarConsentimentoUsingPOST1**
> RetornoConsentimentoPagamentoIniciadoraIniciacao CriarConsentimentoUsingPOST1 (string clientId, ConsentimentoSolicitacaoIniciacao solicitacao)

Criar consentimento para a iniciação de pagamento.

Método de criação do consentimento para a iniciação de pagamento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |
| **solicitacao** | [**ConsentimentoSolicitacaoIniciacao**](ConsentimentoSolicitacaoIniciacao.md) | solicitacao |  |

### Return type

[**RetornoConsentimentoPagamentoIniciadoraIniciacao**](RetornoConsentimentoPagamentoIniciadoraIniciacao.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Consentimento solicitado com sucesso |  -  |
| **400** | Dados inválidos |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listarusingget3"></a>
# **ListarUsingGET3**
> PageConsentimentoPagamentoIniciacao ListarUsingGET3 (string cpf, string status, string clientId, string cnpj = null, string accountNumbe = null, int page = null, int pageSize = null)

Listar consentimento de pagamento.

Operação para listar os consentimentos de pagamento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cpf** | **string** | cpf |  |
| **status** | **string** | Situacao do Pagamento |  |
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |
| **cnpj** | **string** | cnpj | [optional]  |
| **accountNumbe** | **string** | Numero de conta | [optional]  |
| **page** | **int** | pagina | [optional] [default to 0] |
| **pageSize** | **int** | tamanho da pagina | [optional] [default to 10] |

### Return type

[**PageConsentimentoPagamentoIniciacao**](PageConsentimentoPagamentoIniciacao.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gerado com sucesso |  -  |
| **400** | Dados inválidos |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Dados não encontrados |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="retornoautorizacaousingpost1"></a>
# **RetornoAutorizacaoUsingPOST1**
> ConsentimentoPagamentoIniciacaoRetorno RetornoAutorizacaoUsingPOST1 (string clientId, CallbackDataRequest callbackDataRequest)

Atualizar consentimento de pagamento callback

Callback para consulta do status do consentimento de pagamento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |
| **callbackDataRequest** | [**CallbackDataRequest**](CallbackDataRequest.md) | CallbackDataRequest |  |

### Return type

[**ConsentimentoPagamentoIniciacaoRetorno**](ConsentimentoPagamentoIniciacaoRetorno.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Status atual do consentimento de pagamento |  -  |
| **400** | Dados inválidos |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

