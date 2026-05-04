# Sicoob.PagamentosPix.Model.RequisicaoLancamentoEfetivacao

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valor** | **string** | valor do lancamento | 
**MeioIniciacao** | **string** | Meio de iniciação Pix - &#x60;CHAVE&#x60; - &#x60;MANUAL&#x60; - &#x60;QRCODE&#x60; | 
**EndToEndId** | **string** | EndToEndIdentification que transita na PACS002, PACS004 e PACS008 | [optional] 
**Descricao** | **string** | descricao do lancamento | [optional] 
**Repeticao** | **bool** | Flag para indicar pagamento repetido | [optional] 
**DataAgendamento** | **string** | Data do agendamento para pagamentos pretendido | [optional] 
**Origem** | [**DadosContaUsuarioOrigem**](DadosContaUsuarioOrigem.md) |  | [optional] 
**Destino** | [**DadosContaUsuarioDestino**](DadosContaUsuarioDestino.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

