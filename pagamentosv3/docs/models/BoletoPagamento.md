# Sicoob.PagamentosV3.Model.BoletoPagamento

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentificadorConsulta** | **string** | Identificador da consulta do boleto, deverá ser enviado no serviço de pagamento/agendamento. | 
**ValorBoleto** | **double** | Valor nominal do Boleto. | 
**ValorDescontoAbatimento** | **double** | Valor de desconto/abatimento do pagamento do Boleto. | 
**ValorMultaMora** | **double** | Valor de mora/multa do pagamento do Boleto. | 
**AceitaValorDivergente** | **bool** | Entre o agendamento e o pagamento, o boleto poderá sofrer alterações pelo benificiário. Autoriza o pagamento com o valor divergente do agendado? | 
**NumeroCpfCnpjPortador** | **string** | Número do CPF/CNPJ do portador, responsável pelo pagamento. | 
**NomePortador** | **string** | Nome do portador, responsável pelo pagamento. | 
**Amount** | **double** | Valor de pagamento do Boleto. | 
**Date** | **DateOnly** | Data do pagamento do boleto. Se não for informada o pagamento será para data atual. Formato: yyyy-MM-dd  | 
**DebtorAccount** | [**DebtorAccount**](DebtorAccount.md) |  | 
**DescricaoObservacao** | **string** | Descrição da observação informada no pagamento. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

