# Sicoob.Poupanca.Api.ContasApi

All URIs are relative to *https://api.sicoob.com.br/poupanca/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListarContasPoupancaPorInstituicaoEContaCorrente**](ContasApi.md#listarcontaspoupancaporinstituicaoecontacorrente) | **GET** /contas | Consulta de Contas de Poupança |

<a id="listarcontaspoupancaporinstituicaoecontacorrente"></a>
# **ListarContasPoupancaPorInstituicaoEContaCorrente**
> ListaContas ListarContasPoupancaPorInstituicaoEContaCorrente (string clientId)

Consulta de Contas de Poupança

Pesquisa as contas de poupança que pertencem a um CPF ou CNPJ.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | ClientId utilizado na utilização do TOKEN |  |

### Return type

[**ListaContas**](ListaContas.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retorna as contas de poupança do cliente. |  -  |
| **404** | O cliente informado não possui conta poupança. [Página de erros](/#!/erros) |  -  |
| **500** | Erro interno. [Página de erros](/#!/erros) |  -  |
| **503** | Serviço indisponível. [Página de erros](/#!/erros) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

