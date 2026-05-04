# Sicoob.ConvenioPagamentos.Model.HistoricoResultadoRegistrosEInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificadorClienteEmpresa** | **string** | Identificador do cliente na empresa. | [optional] 
**IdentificadorClienteBanco** | **string** | Identificador do cliente, pelo Banco, para efetuar o débito. | [optional] 
**IdentificadorRegistro** | **int** | Identificador do registro de débito. | [optional] 
**Movimento** | **string** | Descrição do movimento. | [optional] 
**DataParceiro** | **DateOnly** | Data em que o parceiro recuperou a informação do registro E. Formato RFC 3339, seção 5.6. | [optional] 
**DataRecepcaoEmpresa** | **DateOnly** | Data em que a informação do registro E foi disponibilizada. Formato RFC 3339, seção 5.6. | [optional] 
**DataVencimento** | **DateOnly** | Data vencimento do débito. Formato RFC 3339, seção 5.6. | [optional] 
**Situacao** | **string** | Situação do débito | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

