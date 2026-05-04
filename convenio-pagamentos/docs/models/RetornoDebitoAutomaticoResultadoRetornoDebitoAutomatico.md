# Sicoob.ConvenioPagamentos.Model.RetornoDebitoAutomaticoResultadoRetornoDebitoAutomatico

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CodigoConvenio** | **string** | Código do convênio. | [optional] 
**SiglaConvenio** | **string** | Sigla do convênio | [optional] 
**IdentificadorClienteEmpresa** | **string** | Identificador do cliente na empresa | [optional] 
**IdentificadorClienteBanco** | **string** | Identificador do cliente no Banco. | [optional] 
**ValorDebito** | **float** | Valor do débito. | [optional] 
**DataVencimento** | **DateOnly** | Data de Vencimento. Formato RFC 3339, seção 5.6. | [optional] 
**DataPagamento** | **DateOnly** | Data do pagamento. Formato RFC 3339, seção 5.6. | [optional] 
**NumeroSequencialDebito** | **int** | Número sequencial do débito. | [optional] 
**NumeroIdentificadorRegistroTipoE** | **int** | Número identificador do registro do débito que chegou da empresa (registro tipo E, padrão FEBRABAN). | [optional] 
**RetornoDebito** | **string** | Retorno do débito automático que foi enviado para a empresa. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

