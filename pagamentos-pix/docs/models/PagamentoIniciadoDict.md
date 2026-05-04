# Sicoob.PagamentosPix.Model.PagamentoIniciadoDict

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndToEndId** | **string** | EndToEndIdentification que transita na PACS002, PACS004 e PACS008 | [optional] 
**Chave** | **string** | Chave de endereçamento para a conta transacional. (Identificador da conta transacional) | [optional] 
**Tipo** | **string** | Tipo da chave:   - &#x60;CPF&#x60; - Identificador de pessoa física   - &#x60;CNPJ&#x60; - Identificado de pessoa jurídica   - &#x60;EMAIL&#x60; - Email   - &#x60;TELEFONE&#x60; - Número de telefone no padrão internacional (&#39;+&#39; +  Código do País + DDD + Telefone) | *Exemplo: +5561999999999*   - &#x60;EVP&#x60; - Token gerado pelo BACEN no formato UUID v4 | [optional] 
**Proprietario** | [**PagamentoIniciadoDictProprietario**](PagamentoIniciadoDictProprietario.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

