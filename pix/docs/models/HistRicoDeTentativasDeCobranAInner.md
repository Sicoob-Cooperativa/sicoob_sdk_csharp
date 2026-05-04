# Sicoob.Pix.Model.HistRicoDeTentativasDeCobranAInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataLiquidacao** | **DateOnly** | Data da liquidação da cobrança. Trata-se de uma data, no formato &#x60;YYYY-MM-DD&#x60;, segundo ISO 8601. | 
**Tipo** | **string** | Tipo da tentativa da cobrança. | 
**Status** | **string** | Status da tentativa da cobrança. | 
**EndToEndId** | **string** | EndToEndIdentification que transita na PACS002, PACS004 e PACS008 | 
**Rejeicao** | [**InformaEsSobreARejeiODaTentativaDaCobranA**](InformaEsSobreARejeiODaTentativaDaCobranA.md) |  | [optional] 
**Atualizacao** | [**List&lt;HistRicoDeStatusInner&gt;**](HistRicoDeStatusInner.md) | Histórico das mudanças de status das cobranças recorrentes. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

