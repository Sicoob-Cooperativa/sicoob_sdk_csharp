# Sicoob.CobrancaV3.Model.RateioCredito

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumeroBanco** | **int** | Número do Banco de Destino | 
**NumeroAgencia** | **int** | Número da Agência de Destino | 
**NumeroContaCorrente** | **string** | Número da Conta Corrente Destino. | 
**ContaPrincipal** | **bool** | Identificador de conta principal. | 
**CodigoTipoValorRateio** | **int** | Tipo de valor do Rateio.   - 1 Percentual   - 2 Valor | 
**ValorRateio** | **string** | Valor do rateio. | 
**NomeTitular** | **string** | Nome completo do titular da conta. &#x60;Tamanho máximo 50&#x60; | 
**CodigoTipoCalculoRateio** | **int** | Tipo de cálculo do Rateio.   - 1 Valor Cobrado | [optional] 
**NumeroCpfCnpjTitular** | **string** | CPF ou CNPJ do titular da conta. &#x60;Tamanho máximo 14&#x60; | [optional] 
**CodigoFinalidadeTed** | **string** | Código da Finalidade TED.   - 1 Pagamento de Impostos, Tributos e Taxas   - 2 Pagamento à Concessionárias de Serviço Público   - 3 Pagamentos de Dividendos   - 4 Pagamento de Salários   - 5 Pagamento de Fornecedores   - 6 Pagamento de Honorários   - 7 Pagamento de Aluguéis e Taxas de Condomínio   - 8 Pagamento de Duplicatas e Títulos   - 9 Pagamento de Mensalidade Escolar   - 10 Crédito em Conta    ...   - 99999 Outros   - Para mais informações acesse https://www.bcb.gov.br/estabilidadefinanceira/comunicacaodados | [optional] 
**CodigoTipoContaDestinoTed** | **string** | Tipo de conta Finalidade TED. &#x60;Tamanho máximo 2&#x60;   - CC Conta Corrente   - CD Conta de Depósito   - CG Conta garantida | [optional] 
**QuantidadeDiasFloat** | **int** | Quantidade de dias float (não informar junto com dataFloatCredito). &#x60;Tamanho máximo 10&#x60; | [optional] 
**DataFloatCredito** | **DateOnly** | Data do float (não informar junto com quantidadeDiasFloat) Formato: yyyy-MM-dd | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

