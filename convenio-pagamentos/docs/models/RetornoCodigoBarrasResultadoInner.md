# Sicoob.ConvenioPagamentos.Model.RetornoCodigoBarrasResultadoInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValorPago** | **double** | Valor pago para arrecadação. | [optional] 
**Nsu** | **decimal** | Código que identifica a transação de forma única. | [optional] 
**DataPagamento** | **DateOnly** | Data de pagamento do boleto. Formato RFC 3339, seção 5.6. | [optional] 
**ValorDocumento** | **double** | Valor do documento para arrecadação. | [optional] 
**ValorDesconto** | **double** | Valor do desconto para arrecadação. | [optional] 
**ValorJuros** | **double** | Valor do juros para arrecadação. | [optional] 
**ValorMulta** | **double** | Valor da multa para arrecadação. | [optional] 
**IdentificadorFgts** | **string** | Informa o identificador do convênico FGTS. | [optional] 
**AnoExercicio** | **decimal** | Informa o ano exercício do pagamento. | [optional] 
**RecebimentoViaCaixa** | **bool** | Indica se o pagamento foi realizado via caixa. | [optional] 
**Autenticacao** | **string** | Informa o número de autenticação digital da arrecadação. | [optional] 
**Situacao** | **int** | Situação da arrecadação | [optional] 
**Convenio** | **string** | Identificador do convênio | [optional] 
**SiglaConvenio** | **string** | Sigla do convênio | [optional] 
**Transacao** | **decimal** | Número da transação utilizada no pagamento do código de barras. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

