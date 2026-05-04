# Sicoob.ContaCorrente.Model.LancamentoSpuOpenBankingRestDTO
Transacoes ocorridas em uma conta corrente no devido mes, ano e dia agrupado de acordo com o tipo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Identificador único de transação. | [optional] 
**Tipo** | **string** | Informação do tipo de transação (Crédito ou Débito). | [optional] 
**Valor** | **string** | Valor referente a transação realizada. | [optional] 
**Data** | **string** | Data e hora que foi realizado a transação. | [optional] 
**DataLote** | **string** | Data de lançamento da transação. | [optional] 
**Descricao** | **string** | Descrição da forma de transação utilizada. | [optional] 
**NumeroDocumento** | **string** | Número identificador da transação. | [optional] 
**CpfCnpj** | **string** | Identificador (CPF ou CNPJ) da pessoa ou estabelecimento da transação. | [optional] 
**DescInfComplementar** | **string** | Descrição complementar será apresentada conforme lançamento da transação. Para transação PIX a informação será apresentada conforme descrição informada pelo cooperado. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

