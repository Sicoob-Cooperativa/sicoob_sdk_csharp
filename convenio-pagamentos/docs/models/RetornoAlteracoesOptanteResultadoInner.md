# Sicoob.ConvenioPagamentos.Model.RetornoAlteracoesOptanteResultadoInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CodigoRegistro** | **string** | Código do registro da alteração de identificação do cliente pela empresa. | [optional] 
**CodigoMovimento** | **int** | Código movimento:  * &#x60;0&#x60; - Alteração da Identificação do Cliente na Empresa  * &#x60;1&#x60; - Exclusão de optante do Débito Automático, solicitação pela Empresa, conforme clausulas contratuais do convênio  | [optional] 
**Convenio** | **string** | Identificador do convênio. | [optional] 
**IdentificadorClienteEmpresaAnterior** | **string** | Identificador do cliente na empresa - Anterior. | [optional] 
**IdentificadorClienteEmpresaAtual** | **string** | Identificador do cliente na empresa - Atual. | [optional] 
**AgenciaDebito** | **int** | O conteúdo deverá ser idêntico ao anteriormente enviado pelo Banco. | [optional] 
**IdentificadorClienteBanco** | **string** | Identificador do cliente, pelo Banco, para efetuar o débito. Informar o número de conta corrente do parceiro no Sicoob. | [optional] 
**Ocorrencia** | **string** | Mensagem | [optional] 
**DataVencimentoContrato** | **int** | Data de vencimento do contrato prazo de validade do contrato formato AAAAMMDD. Prazo de validade indeterminado – Formato 99999999 | [optional] 
**OcorrenciaEspecial1** | [**OcorrenciaEspecial**](OcorrenciaEspecial.md) |  | [optional] 
**OcorrenciaEspecial2** | [**OcorrenciaEspecial**](OcorrenciaEspecial.md) |  | [optional] 
**Movimento** | [**Movimento**](Movimento.md) |  | [optional] 
**NumeroConta** | **int** | Conta autorizada pelo cliente na Destinatária (conta salário/ conta corrente/ conta pagamento, conta poupança) | [optional] 
**Sequencial** | **int** | Identificador sequencial do registro. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

