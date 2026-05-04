# Sicoob.ContaCorrente.Model.ExtratoSpuOpenBankingRestDTO
Extrato e saldo de todas as transacoes ocorridas em uma conta corrente no devido mes, ano e dia agrupado de acordo com o tipo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SaldoAtual** | **string** | Valor de saldo atual disponivel em conta. | [optional] 
**SaldoBloqueado** | **string** | Valor bloqueado em conta. | [optional] 
**SaldoLimite** | **string** | Valor do limite disponivel para utilização. | [optional] 
**SaldoAnterior** | **string** | Valor do saldo anterior será apresentado conforme a informação do campo Mês e Ano. | [optional] 
**SaldoBloqueioJudicial** | **string** | Valor do saldo bloqueado judicialmente conforme a informação do campo Mês e Ano. | [optional] 
**SaldoBloqueioJudicialAnterior** | **string** | Valor do saldo bloqueado judicialmente anterior conforme a informação do campo Mês e Ano. | [optional] 
**Transacoes** | [**List&lt;LancamentoSpuOpenBankingRestDTO&gt;**](LancamentoSpuOpenBankingRestDTO.md) | Lista de transações realizadas referente ao período informado. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

