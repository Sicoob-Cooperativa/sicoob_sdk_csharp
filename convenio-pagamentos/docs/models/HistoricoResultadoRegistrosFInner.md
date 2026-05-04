# Sicoob.ConvenioPagamentos.Model.HistoricoResultadoRegistrosFInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificadorClienteEmpresa** | **string** | Identificador do cliente na empresa. | [optional] 
**IdentificadorClienteBanco** | **string** | Identificador do cliente, pelo Banco, para efetuar o débito. | [optional] 
**IdentificadorRegistroE** | **int** | Identificador do registro de débito (Registro E). | [optional] 
**Movimento** | **string** | Descrição do movimento. | [optional] 
**Data** | **DateOnly** | Data do registro F. Formato RFC 3339, seção 5.6. | [optional] 
**EnvioParceiro** | **bool** | Identifica se o registro foi enviado pelo parceiro. | [optional] 
**DataVencimento** | **DateOnly** | Data vencimento do débito. Formato RFC 3339, seção 5.6. | [optional] 
**Situacao** | **string** | Situação do débito | [optional] 
**Autenticacao** | **string** | Informa o número de autenticação digital do registro B. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

