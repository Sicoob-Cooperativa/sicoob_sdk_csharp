# Sicoob.CobrancaV3.Api.BoletoApi

All URIs are relative to *https://api.sicoob.com.br/cobranca-bancaria/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BoletosFaixasNossoNumeroGet**](BoletoApi.md#boletosfaixasnossonumeroget) | **GET** /boletos/faixas-nosso-numero | Consulta de dados de faixas de nosso número disponíveis. |
| [**BoletosGet**](BoletoApi.md#boletosget) | **GET** /boletos | Consultar boleto |
| [**BoletosNossoNumeroBaixarPost**](BoletoApi.md#boletosnossonumerobaixarpost) | **POST** /boletos/{nossoNumero}/baixar | Comandar a baixa de boletos |
| [**BoletosNossoNumeroPatch**](BoletoApi.md#boletosnossonumeropatch) | **PATCH** /boletos/{nossoNumero} | Alterar dados de um boleto |
| [**BoletosPost**](BoletoApi.md#boletospost) | **POST** /boletos | Incluir boletos |
| [**BoletosSegundaViaGet**](BoletoApi.md#boletossegundaviaget) | **GET** /boletos/segunda-via | Emitir segunda via de um boleto |
| [**PagadoresNumeroCpfCnpjBoletosGet**](BoletoApi.md#pagadoresnumerocpfcnpjboletosget) | **GET** /pagadores/{numeroCpfCnpj}/boletos | Listar Boletos por Pagador |

<a id="boletosfaixasnossonumeroget"></a>
# **BoletosFaixasNossoNumeroGet**
> BoletosFaixasNossoNumeroGet200Response BoletosFaixasNossoNumeroGet (int numeroCliente, int codigoModalidade, int quantidade, long numeroContratoCobranca = null)

Consulta de dados de faixas de nosso número disponíveis.

Serviço para consulta de dados de faixas de nosso número disponíveis.  Quando o campo validaDigitoVerificadorNossoNumero retornar o valor \"0\" a faixa \"numeroInicial\" e \"numeroFinal\" refere-se a numeração final (exemplo: 10 e 15 - utilização: 1-0 1-1 1-2 1-3 1-4 1-5). Mas se o campo validaDigitoVerificadorNossoNumero retornar o valor \"1\" a faixa \"numeroInicial\" e \"numeroFinal\" deverá ser calculado o DV (exemplo: 10 e 15 - utilização: 10-4 11-8 12-0 13-1 14-7 15-9).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numeroCliente** | **int** | Número que identifica o contrato do beneficiário no Sisbr. |  |
| **codigoModalidade** | **int** | Identifica a modalidade do boleto. - 1 - SIMPLES COM REGISTRO - 3 - CAUCIONADA - 4 - VINCULADA - 8 - COBRANÇA CONTA CAPITAL |  |
| **quantidade** | **int** | Quantidade mínima de nosso números que devem estar disponíveis na faixa a ser pesquisada. |  |
| **numeroContratoCobranca** | **long** | Indicar o id do contatro de cobrança | [optional]  |

### Return type

[**BoletosFaixasNossoNumeroGet200Response**](BoletosFaixasNossoNumeroGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **204** | A requisição foi processada com êxito e não está retornando conteúdo. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletosget"></a>
# **BoletosGet**
> BoletosGet200Response BoletosGet (int numeroCliente, int codigoModalidade, int nossoNumero = null, string linhaDigitavel = null, string codigoBarras = null, int numeroContratoCobranca = null)

Consultar boleto

Serviço para consulta de um boleto bancário. Utiliza as informações do beneficiário logado (número da cooperativa, número identificador do beneficiário e conta corrente), juntamente com a informação do identificador do boleto (nosso número), ou da linha digitável ou do código de barras.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numeroCliente** | **int** | Número que identifica o contrato do beneficiário no Sisbr. |  |
| **codigoModalidade** | **int** | Identifica a modalidade do boleto. - 1 - SIMPLES COM REGISTRO - 3 - CAUCIONADA - 4 - VINCULADA - 5 - CARNÊ DE PAGAMENTOS  - 8 - COBRANÇA CONTA CAPITAL |  |
| **nossoNumero** | **int** | Número identificador do boleto no Sisbr. Caso seja infomado, não é necessário infomar a linha digitável ou código de barras. | [optional]  |
| **linhaDigitavel** | **string** | Número da linha digitável do boleto com 47 posições. Caso seja informado, não é necessário informar o nosso número ou código de barras. | [optional]  |
| **codigoBarras** | **string** | Número de código de barras do boleto com 44 posições.Caso seja informado, não é necessário informar o nosso número ou linha digitável. | [optional]  |
| **numeroContratoCobranca** | **int** | Indicar o id do contatro de cobrança | [optional]  |

### Return type

[**BoletosGet200Response**](BoletosGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **204** | A requisição foi processada com êxito e não está retornando conteúdo. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletosnossonumerobaixarpost"></a>
# **BoletosNossoNumeroBaixarPost**
> void BoletosNossoNumeroBaixarPost (int nossoNumero, BoletoBaixa boleto)

Comandar a baixa de boletos

Serviço para comandar a baixa de boletos informados.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boleto** | [**BoletoBaixa**](BoletoBaixa.md) | Informações do boleto de cobrança |  |

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

<a id="boletosnossonumeropatch"></a>
# **BoletosNossoNumeroPatch**
> void BoletosNossoNumeroPatch (int nossoNumero, BoletoAlteracao boleto)

Alterar dados de um boleto

Serviço para alteração de dados de boleto já registrado.  Deve ser feita a alteração de somente um objeto do boleto por requisição. **Objetos de alteração do boleto:** - seuNumero - desconto - abatimento - multa - jurosMora - rateioCredito - pix - prorrogacaoVencimento - prorrogacaoLimitePagamento


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nossoNumero** | **int** | Número que identifica o boleto de cobrança no Sisbr |  |
| **boleto** | [**BoletoAlteracao**](BoletoAlteracao.md) | Informações do boleto de cobrança |  |

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
| **204** | Alteração realizada com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletospost"></a>
# **BoletosPost**
> BoletosPost200Response BoletosPost (Boleto boleto)

Incluir boletos

Serviço para a inclusão de boletos. É possível a inclusão de 1 boleto por requisição.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boleto** | [**Boleto**](Boleto.md) | Inclusão das informações detalhadas do boleto de cobrança. |  |

### Return type

[**BoletosPost200Response**](BoletosPost200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Solicitação recebida com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletossegundaviaget"></a>
# **BoletosSegundaViaGet**
> BoletosSegundaViaGet200Response BoletosSegundaViaGet (int numeroCliente, int codigoModalidade, int nossoNumero = null, string linhaDigitavel = null, string codigoBarras = null, bool gerarPdf = null, long numeroContratoCobranca = null)

Emitir segunda via de um boleto

Serviço para emissão da segunda via de boleto já registrado. Utiliza as informações do beneficiário logado (número da cooperativa, número identificador do beneficiário e conta corrente), juntamente com a informação do identificador do boleto (nosso número), ou da linha digitável ou do código de barras. Quando informados código de barras ou linha digitável, a pesquisa é realiazada prioritariamente por estes parâmetros.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numeroCliente** | **int** | Número que identifica o contrato do beneficiário no Sisbr. |  |
| **codigoModalidade** | **int** | Identifica a modalidade do boleto. - 1 - SIMPLES COM REGISTRO - 3 - CAUCIONADA - 4 - VINCULADA - 5 - CARNÊ DE PAGAMENTOS  - 8 - COBRANÇA CONTA CAPITAL |  |
| **nossoNumero** | **int** | Número identificador do boleto no Sisbr.Caso seja informado, não é necessário informar a linha digitável ou código de barras. | [optional]  |
| **linhaDigitavel** | **string** | Número da linha digitável do boleto com 47 posições.Caso seja informado, não é necessário informar o nosso número ou código de barras. | [optional]  |
| **codigoBarras** | **string** | Número de código de barras do boleto com 44 posições.Caso seja informado, não é necessário informar o nosso número ou a linha digitável. | [optional]  |
| **gerarPdf** | **bool** | Identificador para o sistema devolver ou não o PDF do Boleto. O PDF será retornado na Base64. | [optional]  |
| **numeroContratoCobranca** | **long** | Indicar o id do contatro de cobrança | [optional]  |

### Return type

[**BoletosSegundaViaGet200Response**](BoletosSegundaViaGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **204** | A requisição foi processada com êxito e não está retornando conteúdo. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="pagadoresnumerocpfcnpjboletosget"></a>
# **PagadoresNumeroCpfCnpjBoletosGet**
> PagadoresNumeroCpfCnpjBoletosGet200Response PagadoresNumeroCpfCnpjBoletosGet (string numeroCpfCnpj, int numeroCliente, int codigoSituacao = null, DateOnly dataInicio = null, DateOnly dataFim = null)

Listar Boletos por Pagador

Serviço para listagem de boletos por Pagador.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numeroCpfCnpj** | **string** | CPF ou CNPJ do pagador. &#x60;Tamanho máximo 14&#x60; |  |
| **numeroCliente** | **int** | Número que identifica o contrato do beneficiário no Sisbr. |  |
| **codigoSituacao** | **int** | Código da Situação do Boleto.   - 1 Entrada Normal   - 2 Baixado   - 3 Liquidado | [optional]  |
| **dataInicio** | **DateOnly** | Data de Vencimento Inicial. Formato: yyyy-MM-dd  | [optional]  |
| **dataFim** | **DateOnly** | Data de Vencimento Final. Formato: yyyy-MM-dd  | [optional]  |

### Return type

[**PagadoresNumeroCpfCnpjBoletosGet200Response**](PagadoresNumeroCpfCnpjBoletosGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **204** | A requisição foi processada com êxito e não está retornando conteúdo. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

