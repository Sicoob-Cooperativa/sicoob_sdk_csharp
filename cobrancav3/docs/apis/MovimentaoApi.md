# Sicoob.CobrancaV3.Api.MovimentaoApi

All URIs are relative to *https://api.sicoob.com.br/cobranca-bancaria/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BoletosMovimentacoesDownloadGet**](MovimentaoApi.md#boletosmovimentacoesdownloadget) | **GET** /boletos/movimentacoes/download | Download do(s) arquivo(s) de movimentação. |
| [**BoletosMovimentacoesGet**](MovimentaoApi.md#boletosmovimentacoesget) | **GET** /boletos/movimentacoes | Consultar a situação da solicitação da movimentação |
| [**BoletosMovimentacoesPost**](MovimentaoApi.md#boletosmovimentacoespost) | **POST** /boletos/movimentacoes | Solicitar a movimentação da carteira de cobrança registrada para beneficiário informado |

<a id="boletosmovimentacoesdownloadget"></a>
# **BoletosMovimentacoesDownloadGet**
> BoletosMovimentacoesDownloadGet200Response BoletosMovimentacoesDownloadGet (int numeroCliente, int codigoSolicitacao, int idArquivo)

Download do(s) arquivo(s) de movimentação.

Serviço para obter um arquivo de movimentação.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numeroCliente** | **int** | Número que identifica o contrato do beneficiário no Sisbr. |  |
| **codigoSolicitacao** | **int** | Código da solicitação que deseja consultar a quantidade de arquivos que serão gerados |  |
| **idArquivo** | **int** | ID do arquivo para download |  |

### Return type

[**BoletosMovimentacoesDownloadGet200Response**](BoletosMovimentacoesDownloadGet200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Erro de negócio |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletosmovimentacoesget"></a>
# **BoletosMovimentacoesGet**
> BoletosMovimentacoesGet200Response BoletosMovimentacoesGet (int numeroCliente, int codigoSolicitacao)

Consultar a situação da solicitação da movimentação

Serviço para consultar a situação da solicitação da movimentação.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numeroCliente** | **int** | Número que identifica o contrato do beneficiário no Sisbr. |  |
| **codigoSolicitacao** | **int** | Código da solicitação que deseja consultar a quantidade de arquivos que serão gerados |  |

### Return type

[**BoletosMovimentacoesGet200Response**](BoletosMovimentacoesGet200Response.md)

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
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="boletosmovimentacoespost"></a>
# **BoletosMovimentacoesPost**
> BoletosMovimentacoesPost200Response BoletosMovimentacoesPost (BoletosMovimentacoesPostRequest solicitacao)

Solicitar a movimentação da carteira de cobrança registrada para beneficiário informado

Serviço para solicitar a movimentação da carteira de cobrança registrada para beneficiário informado. Os movimentos disponíveis para solicitaçao são 1. Entrada 2. Prorrogação 3. A Vencer 4. Vencido 5. Liquidação 6. Baixa 7. Vinculado Operações Crédito * As consultas estão limitadas em um período máximo de 2 dias.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **solicitacao** | [**BoletosMovimentacoesPostRequest**](BoletosMovimentacoesPostRequest.md) | Informações da solicitação de movimentação de cobrança. |  |

### Return type

[**BoletosMovimentacoesPost200Response**](BoletosMovimentacoesPost200Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Possíveis erros de negócio. |  -  |
| **406** | Possíveis erros de inconsistência nos dados passados. |  -  |
| **500** | Erro interno |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

