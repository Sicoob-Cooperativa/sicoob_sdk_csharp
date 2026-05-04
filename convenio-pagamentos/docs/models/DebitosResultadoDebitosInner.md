# Sicoob.ConvenioPagamentos.Model.DebitosResultadoDebitosInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CodigoRegistro** | **string** | Código do registro da alteração de identificação do cliente pela empresa. | [optional] 
**IdentificadorClienteEmpresa** | **string** | Identificador do cliente na empresa | [optional] 
**IdentificadorClienteBanco** | **string** | Identificador do cliente, pelo Banco, para efetuar o débito. Informar o número de conta corrente do parceiro no Sicoob. | [optional] 
**Convenio** | **string** | Identificador do convênio. | [optional] 
**Movimento** | **Object** |  | [optional] 
**DataVencimento** | **DateOnly** | Data de Vencimento. Formato RFC 3339, seção 5.6. | [optional] 
**DataVencimentoOriginal** | **DateOnly** | Data de Vencimento Original. Formato RFC 3339, seção 5.6. | [optional] 
**UsoDaEmpresa** | **string** | Informação de origem da Empresa. | [optional] 
**ValorDebito** | **float** | Valor a ser debitado na conta. | [optional] 
**NumeroSequencialDebito** | **int** | Número sequencial do débito. | [optional] 
**NumeroIdentificadorRegistro** | **int** | Número identificador do registro. (Este número deverá ser usado para o retorno do débito, tipo F) | [optional] 
**TipoIdentificacao** | **int** | Tipo da identificação:  * &#x60;1&#x60; -  CPF.  * &#x60;2&#x60; -  CNPJ.  | [optional] 
**Identificacao** | **string** | Identificação do CPF ou do CNPJ de acordo com o tipo da identificação informado. | [optional] 
**TipoOperacao** | **Object** |  | [optional] 
**OpcaoChequeEspecial** | **Object** |  | [optional] 
**OpcaoDebitoParcial** | **Object** |  | [optional] 
**DataPesquisa** | **DateOnly** | Data em que o registro foi recuperado pela primeira vez, quando esta informação não for retornada ou estiver vazio o mesmo está sendo retornado pela primeira vez. | [optional] 
**SituacaoDebito** | **string** | Situação do débito | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

