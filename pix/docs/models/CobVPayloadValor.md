# Sicoob.Pix.Model.CobVPayloadValor
Todos os campos que indicam valores monetários obedecem ao formato do ID 54 da especificação EMV/BR Code para QR Codes. O separador decimal é o caractere ponto. Não é aplicável utilizar separador de milhar. Exemplos de valores aderentes ao padrão: “1.00”, “123.99”, “123456789.23

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Final** | **string** | Valor final da cobrança. | 
**Original** | **string** | Valor original da cobrança. | [optional] 
**Multa** | **string** | Multa aplicada à cobrança | [optional] 
**Juros** | **string** | Juro aplicado à cobrança | [optional] 
**Abatimento** | **string** | Abatimento aplicado à cobrança | [optional] 
**Desconto** | **string** | Descontos aplicados à cobrança | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

