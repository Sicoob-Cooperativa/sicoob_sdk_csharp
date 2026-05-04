# Sicoob.PagamentosPix.Model.PagamentoIniciadoQRCodeResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndToEndId** | **string** | Identificador fim a fim do lancamento | 
**Valor** | **string** | Valor final da transação com 2 casas decimais. | 
**Origem** | [**DadosContaUsuarioOrigem**](DadosContaUsuarioOrigem.md) |  | 
**Destino** | [**DadosContaUsuarioDestino**](DadosContaUsuarioDestino.md) |  | 
**Estado** | **string** |  | [optional] 
**DetalheRejeicao** | **string** | O motivo da recusa | [optional] 
**Descricao** | **string** | descricao do lancamento | [optional] 
**Horario** | **Object** | A data e hora que o lançamento foi atualizado | [optional] 
**DataAgendamento** | **string** | Data do agendamento para pagamentos pretendido | [optional] 
**TxId** | **string** | Identificador da requisicao de pagamentos (TxId) | [optional] 
**ValorOriginal** | **string** | Valor original da transação com 2 casas decimais. | [optional] 
**Abatimento** | **string** | Valor de abatimento com 2 casas decimais. | [optional] 
**Desconto** | **string** | Valor de desconto com 2 casas decimais. | [optional] 
**Multa** | **string** | Valor de multa com 2 casas decimais. | [optional] 
**Juros** | **string** | Valor dos juros com 2 casas decimais. | [optional] 
**TipoQrcode** | **string** | Tipo do qrcode que originou o lançamento | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

