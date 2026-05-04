# Sicoob.ConvenioPagamentos.Model.OcorrenciaOptante

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificadorClienteEmpresaAnterior** | **string** | Identificador do cliente na empresa - Anterior. | 
**IdentificadorClienteEmpresaAtual** | **string** | Identificador do cliente na empresa - Atual. | 
**IdentificadorClienteBanco** | **string** | Identificador do cliente, pelo Banco, para efetuar o débito. Informar o número de conta corrente do parceiro no Sicoob. | 
**Ocorrencia** | **string** | Mensagem explicativa da ocorrência. | 
**CodigoMovimento** | **int** | Código movimento:  * &#x60;0&#x60; - Alteração da Identificação do Cliente na Empresa.  * &#x60;1&#x60; -  Exclusão de optante do Débito Automático, solicitado pela Empresa, conforme clausulas contratuais do convênio  | 
**Convenio** | **string** | Identificador do convênio. | 
**Sequencial** | **int** | Identificador sequencial do registro. | 
**CodigoOcorrenciaEspecial1** | **string** | Código da ocorrência especial 1, em conformidade com o padrão FEBRABAN - Registro H. | [optional] 
**CodigoOcorrenciaEspecial2** | **string** | Código da ocorrência especial 2, em conformidade com o padrão FEBRABAN - Registro H. | [optional] 
**CodigoOcorrenciaEspecial3** | **string** | Código da ocorrência especial 3, em conformidade com o padrão FEBRABAN - Registro H. | [optional] 
**CodigoOcorrenciaEspecial4** | **string** | Código da ocorrência especial 4, em conformidade com o padrão FEBRABAN - Registro H. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

