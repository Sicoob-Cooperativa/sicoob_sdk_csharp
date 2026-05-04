# Sicoob.PagamentosV3.Api.PagamentoApi

All URIs are relative to *https://api.sicoob.com.br/pagamentos/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BoletosCodigoBarrasGet**](PagamentoApi.md#boletoscodigobarrasget) | **GET** /boletos/{codigoBarras} | Consultar Boleto |
| [**BoletosPagamentosAgendamentosIdPagamentoDelete**](PagamentoApi.md#boletospagamentosagendamentosidpagamentodelete) | **DELETE** /boletos/pagamentos/agendamentos/{idPagamento} | Cancelar um agendamento de pagamento |
| [**BoletosPagamentosCodigoBarrasPost**](PagamentoApi.md#boletospagamentoscodigobarraspost) | **POST** /boletos/pagamentos/{codigoBarras} | Pagar Boleto |
| [**BoletosPagamentosIdPagamentoComprovantesGet**](PagamentoApi.md#boletospagamentosidpagamentocomprovantesget) | **GET** /boletos/pagamentos/{idPagamento}/comprovantes | Consultar comprovante de pagamento |
| [**BoletosPagamentosIdempotencyIdempotencyComprovantesGet**](PagamentoApi.md#boletospagamentosidempotencyidempotencycomprovantesget) | **GET** /boletos/pagamentos/{idempotency}/idempotency/comprovantes | Consultar comprovante de pagamento através do Idempotency. |

<a id="boletoscodigobarrasget"></a>
# **BoletosCodigoBarrasGet**
> BoletosCodigoBarrasGet200Response BoletosCodigoBarrasGet (string clientId, string codigoBarras, long numeroConta, DateOnly dataPagamento = null)

Consultar Boleto

Serviço para consultar boleto.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **codigoBarras** | **string** | Número de código de barras com 44 posições ou linha digitável com 47 posições do boleto |  |
| **numeroConta** | **long** | Número da Conta Habilitada para Pagamentos via API. |  |
| **dataPagamento** | **DateOnly** | Data do pagamento do boleto. Se não for informada o pagamento será para data atual Formato: yyyy-MM-dd Exemplo: 2022-07-30  | [optional]  |

### Return type

[**BoletosCodigoBarrasGet200Response**](BoletosCodigoBarrasGet200Response.md)

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

<a id="boletospagamentosagendamentosidpagamentodelete"></a>
# **BoletosPagamentosAgendamentosIdPagamentoDelete**
> void BoletosPagamentosAgendamentosIdPagamentoDelete (string clientId, long idPagamento, Cancelamento cancelamento)

Cancelar um agendamento de pagamento

Serviço para cancelar um agendamento de pagamento.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **idPagamento** | **long** | Número de identificação do agendamento no SISBR. |  |
| **cancelamento** | [**Cancelamento**](Cancelamento.md) | Dados da Conta Habilitada para Pagamentos via API. |  |

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
| **204** | Requisição processada com sucesso e não há conteúdo a ser retornado. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletospagamentoscodigobarraspost"></a>
# **BoletosPagamentosCodigoBarrasPost**
> BoletosPagamentosCodigoBarrasPost200Response BoletosPagamentosCodigoBarrasPost (string clientId, string xIdempotencyKey, string codigoBarras, BoletoPagamento boletoPagamento)

Pagar Boleto

Serviço para efetuar o pagamento ou agendamento de boleto.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **xIdempotencyKey** | **string** | Este parâmetro é usado para garantir a idempotência das requisições, ajudando a evitar operações duplicadas.  Para cada requisição que deseja ser tratada de forma idempotente, envie um valor exclusivo.  Esse valor deve ser uma string única que segue um padrão específico: começa com um número de cooperativa (com até 4 dígitos), seguido do número da conta corrente (com até 14 dígitos), e termina com um UUID (Universally Unique Identifier).  Ex:4342-8901234-550e8400-e29b-41d4-a716-446655440000.  [Especificação do UUID](https://datatracker.ietf.org/doc/html/rfc4122)  |  |
| **codigoBarras** | **string** | Número de código de barras do boleto com 44 posições |  |
| **boletoPagamento** | [**BoletoPagamento**](BoletoPagamento.md) | Dados do boleto a ser pago ou agendado |  |

### Return type

[**BoletosPagamentosCodigoBarrasPost200Response**](BoletosPagamentosCodigoBarrasPost200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **202** | Pendência de assinatura processada com sucesso e não há conteúdo a ser retornado. |  -  |
| **204** | Requisição processada com sucesso e não há conteúdo a ser retornado. |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletospagamentosidpagamentocomprovantesget"></a>
# **BoletosPagamentosIdPagamentoComprovantesGet**
> BoletosPagamentosIdPagamentoComprovantesGet200Response BoletosPagamentosIdPagamentoComprovantesGet (string clientId, long idPagamento, long numeroConta)

Consultar comprovante de pagamento

Serviço para consultar um comprovante de um pagamento efetuado.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **idPagamento** | **long** | Número de identificação do agendamento no SISBR. |  |
| **numeroConta** | **long** | Número da Conta Habilitada para Pagamentos via API. |  |

### Return type

[**BoletosPagamentosIdPagamentoComprovantesGet200Response**](BoletosPagamentosIdPagamentoComprovantesGet200Response.md)

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
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletospagamentosidempotencyidempotencycomprovantesget"></a>
# **BoletosPagamentosIdempotencyIdempotencyComprovantesGet**
> BoletosPagamentosCodigoBarrasPost200Response BoletosPagamentosIdempotencyIdempotencyComprovantesGet (string clientId, string idempotency)

Consultar comprovante de pagamento através do Idempotency.

Serviço para consultar um comprovante de um pagamento efetuado através do Idempotency.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado para gerar o token. |  |
| **idempotency** | **string** | Este parâmetro é usado para garantir a idempotência das requisições, ajudando a evitar operações duplicadas. |  |

### Return type

[**BoletosPagamentosCodigoBarrasPost200Response**](BoletosPagamentosCodigoBarrasPost200Response.md)

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
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

