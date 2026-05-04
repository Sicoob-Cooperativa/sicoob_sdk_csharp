# Sicoob.ConvenioPagamentos.Api.ArrecadaoApi

All URIs are relative to *https://api.sicoob.com.br/convenios-pagamentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ArrecadacaoCodigoBarrasCodigoBarrasGet**](ArrecadaoApi.md#arrecadacaocodigobarrascodigobarrasget) | **GET** /arrecadacao/codigo-barras/{codigoBarras} | Consulta informações do código de barras |
| [**ArrecadacaoCodigoBarrasCodigoBarrasPagamentosGet**](ArrecadaoApi.md#arrecadacaocodigobarrascodigobarraspagamentosget) | **GET** /arrecadacao/codigo-barras/{codigoBarras}/pagamentos | Consulta informações sobre o pagamento associado ao código de barras e à data de movimentação. |
| [**ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPost**](ArrecadaoApi.md#arrecadacaocodigobarrascodigobarraspagamentospost) | **POST** /arrecadacao/codigo-barras/{codigoBarras}/pagamentos | Arrecadação de convênios por meio de código de barras |
| [**ArrecadacaoConciliacoesGet**](ArrecadaoApi.md#arrecadacaoconciliacoesget) | **GET** /arrecadacao/conciliacoes | Consulta de conciliação das arrecadações. |
| [**ArrecadacaoConveniosHabilitadosGet**](ArrecadaoApi.md#arrecadacaoconvenioshabilitadosget) | **GET** /arrecadacao/convenios-habilitados | Listagem de convênios habilitados. |
| [**ArrecadacaoPagamentosNsuComprovanteGet**](ArrecadaoApi.md#arrecadacaopagamentosnsucomprovanteget) | **GET** /arrecadacao/pagamentos/{nsu}/comprovante | Consulta de segunda via de pagamento. |

<a id="arrecadacaocodigobarrascodigobarrasget"></a>
# **ArrecadacaoCodigoBarrasCodigoBarrasGet**
> ArrecadacaoCodigoBarrasCodigoBarrasGet200Response ArrecadacaoCodigoBarrasCodigoBarrasGet (string codigoBarras, DateOnly dataPagamento, bool recebimentoViaCaixa = null)

Consulta informações do código de barras

Este serviço tem como objetivo a consulta de informações de um código de barras e data de pagamento.  **Recomendação:**   - Consultar o serviço '/arrecadacao/convenios-habilitados' para verificar quais convênios estão disponíveis através desta API.   **Exclusivo para o perfil \"Parceiro Banco Sicoob\":**   - O atributo 'recebimentoViaCaixa' somente poderá ser informado por este perfil.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codigoBarras** | **string** | Número do código de barras (sem dígito verificador). |  |
| **dataPagamento** | **DateOnly** | Data de pagamento. Formato RFC 3339, seção 5.6 (yyyy-mm-dd). |  |
| **recebimentoViaCaixa** | **bool** | Indica se o pagamento foi realizado via caixa. | [optional]  |

### Return type

[**ArrecadacaoCodigoBarrasCodigoBarrasGet200Response**](ArrecadacaoCodigoBarrasCodigoBarrasGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="arrecadacaocodigobarrascodigobarraspagamentosget"></a>
# **ArrecadacaoCodigoBarrasCodigoBarrasPagamentosGet**
> RetornoCodigoBarras ArrecadacaoCodigoBarrasCodigoBarrasPagamentosGet (string codigoBarras, decimal instituicao, DateOnly dataMovimento, decimal transacao = null)

Consulta informações sobre o pagamento associado ao código de barras e à data de movimentação.

Este serviço tem como objetivo a consulta de informações de um código de barras.   Para parceiros do \"**Parceiro Banco Sicoob**\", o atributo nsu (Número Sequencial Único), obrigatório para a transação de pagamento.    **Exclusivo para o perfil \"Parceiro Banco Sicoob\":**   - O atributo 'recebimentoViaCaixa' uso exclusivo por este perfil.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codigoBarras** | **string** | Número do código de barras (sem dígito verificador). |  |
| **instituicao** | **decimal** | Número identificador da instituição: para os cooperados, este campo deve conter o número da cooperativa. Para os parceiros, solicitamos que verifiquem com a área gestora o valor a ser informado. |  |
| **dataMovimento** | **DateOnly** | Data de movimento. Formato RFC 3339, seção 5.6. |  |
| **transacao** | **decimal** | Código identificador da transação do parceiro. | [optional]  |

### Return type

[**RetornoCodigoBarras**](RetornoCodigoBarras.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="arrecadacaocodigobarrascodigobarraspagamentospost"></a>
# **ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPost**
> ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPost200Response ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPost (string codigoBarras, ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPostRequest arrecadacao)

Arrecadação de convênios por meio de código de barras

Este serviço tem como objetivo a arrecadação de convênios por meio de código de barras.   **Recomendação:**   - Consultar o serviço '/arrecadacao/convenios-habilitados' para verificar quais convênios estão disponíveis através desta API.   **Exclusivo para o perfil \"Parceiro Banco Sicoob\":**   - O atributo nsu (Número Sequencial Único), obrigatório para a execução deste serviço.   - Deverá consultar o serviço '/arrecadacao/codigo-barras/{codigoBarras}'   - O atributo 'recebimentoViaCaixa' somente poderá ser informado por este perfil.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codigoBarras** | **string** | Número do código de barras (sem dígito verificador). |  |
| **arrecadacao** | [**ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPostRequest**](ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPostRequest.md) | Metadados para arrecadação de convênios. |  |

### Return type

[**ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPost200Response**](ArrecadacaoCodigoBarrasCodigoBarrasPagamentosPost200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pagamento realizado com sucesso. |  -  |
| **202** | A transação esta pendente de assinatura. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="arrecadacaoconciliacoesget"></a>
# **ArrecadacaoConciliacoesGet**
> Conciliacao ArrecadacaoConciliacoesGet (DateOnly dataMovimento, decimal instituicao, int unidade = null)

Consulta de conciliação das arrecadações.

Este serviço tem como objeto a consulta de informações sintéticas das arrecadações realizadas em uma data de movimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataMovimento** | **DateOnly** | Data de movimento. Formato RFC 3339, seção 5.6. |  |
| **instituicao** | **decimal** | Número identificador da instituição: para os cooperados, este campo deve conter o número da cooperativa. Para os parceiros, solicitamos que verifiquem com a área gestora o valor a ser informado. |  |
| **unidade** | **int** | Número identificador da unidade. | [optional]  |

### Return type

[**Conciliacao**](Conciliacao.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso. |  -  |
| **400** | Possíveis erros de negócio ao exibir as informações de convênios. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="arrecadacaoconvenioshabilitadosget"></a>
# **ArrecadacaoConveniosHabilitadosGet**
> ConveniosHabilitados ArrecadacaoConveniosHabilitadosGet (decimal transacao, decimal instituicao)

Listagem de convênios habilitados.

'Este serviço tem como objetivo retornar uma listagem contendo os convênios habilitados para arrecadação nesta API'.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do cliente. |  |
| **instituicao** | **decimal** | Número identificador da instituição: para os cooperados, este campo deve conter o número da cooperativa. Para os parceiros, solicitamos que verifiquem com a área gestora o valor a ser informado. |  |

### Return type

[**ConveniosHabilitados**](ConveniosHabilitados.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Consulta realizada com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="arrecadacaopagamentosnsucomprovanteget"></a>
# **ArrecadacaoPagamentosNsuComprovanteGet**
> ArrecadacaoPagamentosNsuComprovanteGet200Response ArrecadacaoPagamentosNsuComprovanteGet (decimal nsu, decimal instituicao)

Consulta de segunda via de pagamento.

Este serviço tem como objeto o retorno das informações de uma arrecadação contendo a segunda via do comprovante.     **Exclusivo para o perfil \"Parceiro Banco Sicoob\":**   - O atributo 'recebimentoViaCaixa' uso exclusivo por este perfil.   


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nsu** | **decimal** | Número sequencial único: código que identifica a transação de arrecadação realizada. |  |
| **instituicao** | **decimal** | Número identificador da instituição: para os cooperados, este campo deve conter o número da cooperativa. Para os parceiros, solicitamos que verifiquem com a área gestora o valor a ser informado. |  |

### Return type

[**ArrecadacaoPagamentosNsuComprovanteGet200Response**](ArrecadacaoPagamentosNsuComprovanteGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retorno da segunda via do comprovante de pagamento. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

