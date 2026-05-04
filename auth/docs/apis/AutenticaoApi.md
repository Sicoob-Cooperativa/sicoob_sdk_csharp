# Sicoob.Auth.Api.AutenticaoApi

All URIs are relative to *https://auth.sicoob.com.br*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthRealmsCooperadoProtocolOpenidConnectTokenPost**](AutenticaoApi.md#authrealmscooperadoprotocolopenidconnecttokenpost) | **POST** /auth/realms/cooperado/protocol/openid-connect/token | Gerar token de acesso |

<a id="authrealmscooperadoprotocolopenidconnecttokenpost"></a>
# **AuthRealmsCooperadoProtocolOpenidConnectTokenPost**
> AuthRealmsCooperadoProtocolOpenidConnectTokenPost200Response AuthRealmsCooperadoProtocolOpenidConnectTokenPost (string clientId, string grantType, string scope)

Gerar token de acesso

Endpoint para geração de token de acesso via Client Credentials com mTLS.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **grantType** | **string** |  | [default to &quot;client_credentials&quot;] |
| **scope** | **string** |  | [default to &quot;cco_transferencias cco_consulta openid&quot;] |

### Return type

[**AuthRealmsCooperadoProtocolOpenidConnectTokenPost200Response**](AuthRealmsCooperadoProtocolOpenidConnectTokenPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token gerado com sucesso |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

