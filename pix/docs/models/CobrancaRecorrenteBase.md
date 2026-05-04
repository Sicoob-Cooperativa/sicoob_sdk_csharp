# Sicoob.Pix.Model.CobrancaRecorrenteBase
Atributos de cobrança recorrente

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InfoAdicional** | **string** | Informações adicionais da fatura. | [optional] 
**Calendario** | [**InformaEsSobreCalendRioDaCobranA1**](InformaEsSobreCalendRioDaCobranA1.md) |  | [optional] 
**Valor** | [**ValorDaCobranARecorrente1**](ValorDaCobranARecorrente1.md) |  | [optional] 
**AjusteDiaUtil** | **bool** | Campo de ativação do ajuste da data prevista para liquidação para próximo dia útil caso o vencimento corrente seja um dia não útil. O PSP Recebedor deverá considerar os feriados locais com base no código município do usuário pagador. | [default to true]
**Recebedor** | [**DadosBancariosRecebedor**](DadosBancariosRecebedor.md) | O objeto recebedor organiza as informações sobre o recebedor da cobrança. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

