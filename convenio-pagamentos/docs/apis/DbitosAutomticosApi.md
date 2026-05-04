# Sicoob.ConvenioPagamentos.Api.DbitosAutomticosApi

All URIs are relative to *https://api.sicoob.com.br/convenios-pagamentos/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DebitoAutomaticoDebitosAutenticacaoGet**](DbitosAutomticosApi.md#debitoautomaticodebitosautenticacaoget) | **GET** /debito-automatico/debitos/{autenticacao} | Consulta o retorno de um débito automático. |
| [**DebitoAutomaticoDebitosConciliacoesGet**](DbitosAutomticosApi.md#debitoautomaticodebitosconciliacoesget) | **GET** /debito-automatico/debitos/conciliacoes | Consulta de conciliação das arrecadações. |
| [**DebitoAutomaticoDebitosGet**](DbitosAutomticosApi.md#debitoautomaticodebitosget) | **GET** /debito-automatico/debitos | Consulta de débitos em conta gerados pela Empresa para o Banco. |
| [**DebitoAutomaticoDebitosMovimentacoesGet**](DbitosAutomticosApi.md#debitoautomaticodebitosmovimentacoesget) | **GET** /debito-automatico/debitos/movimentacoes | Consulta a movimentação dos débitos. |
| [**DebitoAutomaticoDebitosMovimentacoesPost**](DbitosAutomticosApi.md#debitoautomaticodebitosmovimentacoespost) | **POST** /debito-automatico/debitos/movimentacoes | Retorno de débitos automáticos em lote. |
| [**DebitoAutomaticoDebitosPost**](DbitosAutomticosApi.md#debitoautomaticodebitospost) | **POST** /debito-automatico/debitos | Cadastramento do retorno do débito automático. |
| [**DebitoAutomaticoOptantesAlteracoesGet**](DbitosAutomticosApi.md#debitoautomaticooptantesalteracoesget) | **GET** /debito-automatico/optantes/alteracoes | Alterações da identificação do cliente realizado pela Empresa para o Banco, conforme padrão Febraban |
| [**DebitoAutomaticoOptantesConveniosGet**](DbitosAutomticosApi.md#debitoautomaticooptantesconveniosget) | **GET** /debito-automatico/optantes/convenios | Lista de convênios |
| [**DebitoAutomaticoOptantesHistoricoGet**](DbitosAutomticosApi.md#debitoautomaticooptanteshistoricoget) | **GET** /debito-automatico/optantes/historico | Consulta de histórico de optantes. |
| [**DebitoAutomaticoOptantesOcorrenciasPost**](DbitosAutomticosApi.md#debitoautomaticooptantesocorrenciaspost) | **POST** /debito-automatico/optantes/ocorrencias | Cadastramento de ocorrências de alteração do cadastro do cliente. |
| [**DebitoAutomaticoOptantesPost**](DbitosAutomticosApi.md#debitoautomaticooptantespost) | **POST** /debito-automatico/optantes | Cadastramento de optantes para débito automático. |
| [**DebitoAutomaticoOptantesRecusasGet**](DbitosAutomticosApi.md#debitoautomaticooptantesrecusasget) | **GET** /debito-automatico/optantes/recusas | Recusas dos cadastros de optantes por parte da empresa |
| [**DebitoAutomaticoOptantesValidacoesPost**](DbitosAutomticosApi.md#debitoautomaticooptantesvalidacoespost) | **POST** /debito-automatico/optantes/validacoes | Faz a validação de optantes para inclusão em débito automático. |

<a id="debitoautomaticodebitosautenticacaoget"></a>
# **DebitoAutomaticoDebitosAutenticacaoGet**
> RetornoDebitoAutomatico DebitoAutomaticoDebitosAutenticacaoGet (string autenticacao, decimal transacao)

Consulta o retorno de um débito automático.

Consulta os dados de retorno de um débito automático usando a chave de autenticação.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autenticacao** | **string** | Chave de autenticacao. |  |
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |

### Return type

[**RetornoDebitoAutomatico**](RetornoDebitoAutomatico.md)

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

<a id="debitoautomaticodebitosconciliacoesget"></a>
# **DebitoAutomaticoDebitosConciliacoesGet**
> ConciliacaoDebitoAutomatico DebitoAutomaticoDebitosConciliacoesGet (decimal transacao, decimal data)

Consulta de conciliação das arrecadações.

Retorna as informações de conciliação das arrecadações por data de movimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **data** | **decimal** | Data do movimento. Formato RFC 3339, seção 5.6. |  |

### Return type

[**ConciliacaoDebitoAutomatico**](ConciliacaoDebitoAutomatico.md)

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

<a id="debitoautomaticodebitosget"></a>
# **DebitoAutomaticoDebitosGet**
> Debitos DebitoAutomaticoDebitosGet (decimal transacao, decimal pagina, DateOnly data = null)

Consulta de débitos em conta gerados pela Empresa para o Banco.

Consulta os débitos em conta gerados pela Empresa para o Banco, conforme padrão Febraban Registro E


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **pagina** | **decimal** | Número da página. Quando não utilizar o query parameter data é obrigatório que seja sempre repassado o valor 1 neste query parameter. Quando utilizar o query parameter data a página deverá estar contidada dentro do retorno do objeto paginação atributo &#39;totalPaginas&#39;. |  |
| **data** | **DateOnly** | Data de movimento. Utilizar padrão: yyyy-MM-dd. | [optional]  |

### Return type

[**Debitos**](Debitos.md)

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

<a id="debitoautomaticodebitosmovimentacoesget"></a>
# **DebitoAutomaticoDebitosMovimentacoesGet**
> DebitosMovimento DebitoAutomaticoDebitosMovimentacoesGet (decimal transacao, decimal pagina, DateOnly data)

Consulta a movimentação dos débitos.

Consulta as informações de movimentação dos débitos automáticos por data de movimento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **pagina** | **decimal** | Número da página. Quando não utilizar o query parameter data é obrigatório que seja sempre repassado o valor 1 neste query parameter. Quando utilizar o query parameter data a página deverá estar contidada dentro do retorno do objeto paginação atributo &#39;totalPaginas&#39;. |  |
| **data** | **DateOnly** | Data de movimento. Utilizar padrão: yyyy-MM-dd. |  |

### Return type

[**DebitosMovimento**](DebitosMovimento.md)

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

<a id="debitoautomaticodebitosmovimentacoespost"></a>
# **DebitoAutomaticoDebitosMovimentacoesPost**
> RetornoDebitoAutomaticoLote DebitoAutomaticoDebitosMovimentacoesPost (DebitosMovimentacaoLote respostaDebitosLote)

Retorno de débitos automáticos em lote.

Serviço para o envio de registros tipo F (padrão FEBRABAN) de débitos automáticos em lote. Com um limite de 100 registros por requisição.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **respostaDebitosLote** | [**DebitosMovimentacaoLote**](DebitosMovimentacaoLote.md) | Cadastro do retorno de débitos automáticos. |  |

### Return type

[**RetornoDebitoAutomaticoLote**](RetornoDebitoAutomaticoLote.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **207** | Solicitação recebida com sucesso. Verifique o status de cada registro no retorno. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="debitoautomaticodebitospost"></a>
# **DebitoAutomaticoDebitosPost**
> DebitoAutomaticoDebitosPost201Response DebitoAutomaticoDebitosPost (DebitoAutomaticoDebitosPostRequest debito)

Cadastramento do retorno do débito automático.

Cadastramento de retorno do débito automático enviado pela empresa (tipo E), padrão FEBRABAN registro F.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **debito** | [**DebitoAutomaticoDebitosPostRequest**](DebitoAutomaticoDebitosPostRequest.md) | Requisição para o cadastramento do retorno do débito automático. |  |

### Return type

[**DebitoAutomaticoDebitosPost201Response**](DebitoAutomaticoDebitosPost201Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Retorno de débito cadastrado com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="debitoautomaticooptantesalteracoesget"></a>
# **DebitoAutomaticoOptantesAlteracoesGet**
> RetornoAlteracoesOptante DebitoAutomaticoOptantesAlteracoesGet (decimal transacao, DateOnly data = null)

Alterações da identificação do cliente realizado pela Empresa para o Banco, conforme padrão Febraban

Consulta as alterações da identificação do cliente realizado pela Empresa para o Banco, conforme padrão Febraban Registro D


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **data** | **DateOnly** | Data de movimento. Utilizar padrão: yyyy-MM-dd. | [optional]  |

### Return type

[**RetornoAlteracoesOptante**](RetornoAlteracoesOptante.md)

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

<a id="debitoautomaticooptantesconveniosget"></a>
# **DebitoAutomaticoOptantesConveniosGet**
> Convenios DebitoAutomaticoOptantesConveniosGet (decimal transacao, bool todosConvenios = null)

Lista de convênios

Lista os convênios que estão aptos a trabalhar com débito automático.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **todosConvenios** | **bool** | Parâmetro que indica a listagem completa dos convenios ou apenas os convênios que permitem o cadastro de optante  * &#x60;true&#x60; - LISTA TODOS OS CONVÊNIOS QUE ESTÃO DISPONÍVEIS NA API  * &#x60;false&#x60; - APENAS OS CONVÊNIOS QUE PERMITEM O CADASTRO DE OPTANTE  | [optional] [default to false] |

### Return type

[**Convenios**](Convenios.md)

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

<a id="debitoautomaticooptanteshistoricoget"></a>
# **DebitoAutomaticoOptantesHistoricoGet**
> Historico DebitoAutomaticoOptantesHistoricoGet (decimal transacao, string identificadorClienteEmpresa, string convenio, string identificadorClienteBanco = null, decimal ano = null)

Consulta de histórico de optantes.

Retorna as informações de registros B, C, E e F (código de registros segundo o leiaute FEBRABAN) de optantes. As informações serão retornadas por ano.  Exemplo: Ano igual 2021 retornará os registros de Janeiro a Dezembro de 2021.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **identificadorClienteEmpresa** | **string** | Identificador do cliente na empresa. |  |
| **convenio** | **string** | Código do convênio. |  |
| **identificadorClienteBanco** | **string** | Identificador do cliente no banco. | [optional]  |
| **ano** | **decimal** | Ano de pesquisa, usar o padrão AAAA. | [optional]  |

### Return type

[**Historico**](Historico.md)

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

<a id="debitoautomaticooptantesocorrenciaspost"></a>
# **DebitoAutomaticoOptantesOcorrenciasPost**
> DebitoAutomaticoOptantesPost201Response DebitoAutomaticoOptantesOcorrenciasPost (DebitoAutomaticoOptantesOcorrenciasPostRequest optante)

Cadastramento de ocorrências de alteração do cadastro do cliente.

Cadastramento de ocorrências de alteração do cadastro do cliente para débito automático, padrão FEBRABAN registro H.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optante** | [**DebitoAutomaticoOptantesOcorrenciasPostRequest**](DebitoAutomaticoOptantesOcorrenciasPostRequest.md) | Requisição de cadastramento de ocorrências. |  |

### Return type

[**DebitoAutomaticoOptantesPost201Response**](DebitoAutomaticoOptantesPost201Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Cadastro realizado com sucesso. |  -  |
| **400** | Possíveis erros de negócio ao exibir as informações de convênios. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="debitoautomaticooptantespost"></a>
# **DebitoAutomaticoOptantesPost**
> DebitoAutomaticoOptantesPost201Response DebitoAutomaticoOptantesPost (DebitoAutomaticoOptantesPostRequest optante)

Cadastramento de optantes para débito automático.

Realiza o cadastramento de optantes para débitos automático, padrão FEBRABAN registro B.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optante** | [**DebitoAutomaticoOptantesPostRequest**](DebitoAutomaticoOptantesPostRequest.md) | Requisição de cadastramento de optantes. |  |

### Return type

[**DebitoAutomaticoOptantesPost201Response**](DebitoAutomaticoOptantesPost201Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Cadastro realizado com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="debitoautomaticooptantesrecusasget"></a>
# **DebitoAutomaticoOptantesRecusasGet**
> OcorrenciasCadastroOptante DebitoAutomaticoOptantesRecusasGet (decimal transacao, DateOnly data = null)

Recusas dos cadastros de optantes por parte da empresa

Consulta as recusas dos cadastros de optantes, registro enviado da Empresa para o Banco, conforme padrão Febraban Registro C


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transacao** | **decimal** | Código identificador da transação do parceiro. |  |
| **data** | **DateOnly** | Data de movimento. Utilizar padrão: yyyy-MM-dd. | [optional]  |

### Return type

[**OcorrenciasCadastroOptante**](OcorrenciasCadastroOptante.md)

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

<a id="debitoautomaticooptantesvalidacoespost"></a>
# **DebitoAutomaticoOptantesValidacoesPost**
> DebitoAutomaticoOptantesValidacoesPost201Response DebitoAutomaticoOptantesValidacoesPost (DebitoAutomaticoOptantesPostRequest optante)

Faz a validação de optantes para inclusão em débito automático.

Realiza o validação das informações de optantes para débitos automático, padrão FEBRABAN registro B.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optante** | [**DebitoAutomaticoOptantesPostRequest**](DebitoAutomaticoOptantesPostRequest.md) | Requisição de validação de de optantes. |  |

### Return type

[**DebitoAutomaticoOptantesValidacoesPost201Response**](DebitoAutomaticoOptantesValidacoesPost201Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Validação efetuada com sucesso. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **500** | Erro interno. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

