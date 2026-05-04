# Sicoob.Pix.Model.ListaDeDescontosInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **DateOnly** | Descontos por pagamento antecipado, com data fixa. Matriz com até três elementos, sendo que cada elemento é composto por um par \&quot;data e valorPerc\&quot;, para estabelecer descontos percentuais ou absolutos, até aquela data de pagamento. Trata-se de uma data, no formato &#x60;YYYY-MM-DD&#x60;, segundo ISO 8601. A data de desconto obrigatoriamente deverá ser menor que a data de vencimento da cobrança. | 
**ValorPerc** | **string** | Desconto em valor absoluto ou percentual por dia, útil ou corrido, conforme valor.desconto.modalidade | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

