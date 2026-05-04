# Sicoob.ConvenioPagamentos.Model.DebitosMovimentoResultadoDebitosInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificadorConvenio** | **string** | Identificador do convênio. | [optional] 
**SiglaConvenio** | **string** | Sigla do convênio. | [optional] 
**IdentificadorClienteEmpresa** | **string** | Identificador do cliente na empresa | [optional] 
**IdentificadorClienteBanco** | **string** | Identificador do cliente, pelo Banco, para efetuar o débito. Informar o número de conta corrente do parceiro no Sicoob. | [optional] 
**Movimento** | **string** | Descrição do movimento. | [optional] 
**DataVencimento** | **DateOnly** | Data de Vencimento. Formato RFC 3339, seção 5.6. | [optional] 
**DataVencimentoOriginal** | **DateOnly** | Data de Vencimento Original. Formato RFC 3339, seção 5.6. | [optional] 
**ValorDebito** | **float** | Valor a ser debitado na conta. | [optional] 
**NumeroSequencialDebito** | **int** | Número sequencial do débito. | [optional] 
**NumeroIdentificadorRegistro** | **int** | Número identificador do registro. (Este número deverá ser usado para o retorno do débito, tipo E) | [optional] 
**CodigoRetorno** | **string** | Código do retorno. | [optional] 
**DescricaoRetorno** | **string** | Descrição do retorno. | [optional] 
**Autenticacao** | **string** | Autenticação do débito. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

