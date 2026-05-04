# Sicoob.Poupanca.Model.Transferencia

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | Data em que deve ser realizada a operação (yyyy-MM-dd) | 
**Amount** | **decimal** | Valor da operação | 
**DebtorAccount** | [**TransferenciaDebtorAccount**](TransferenciaDebtorAccount.md) |  | 
**CreditorAccount** | [**TransferenciaDebtorAccount**](TransferenciaDebtorAccount.md) |  | 
**IdUsuario** | **string** | Usuário que realizou a operação | 
**IdProduto** | **decimal** | Identificador do Produto que efetuou a operação | 
**CodCanal** | **int** | O identificador do canal cadastrado no CTR | 
**Valor** | **decimal** | Valor da operação | 
**DataLancamento** | **string** | Data em que deve ser realizada a operação | 
**NumeroCooperativaMovimento** | **int** | Numero da cooperativa responsavel pela operacao | 
**NumeroCooperativaDebito** | **int** | Numero da cooperativa da conta de débito | 
**NumeroContaDebito** | **decimal** | Número da conta onde será feito o débito | 
**NumeroCooperativaCredito** | **int** | Numero da cooperativa da conta de crédito | 
**NumeroContaCredito** | **decimal** | Número da conta onde será feito o crédito | 
**NomeArquivoCNAB** | **string** | Nome do arquivo CNAB a ser repassado para o sistema de conta corrente | [optional] 
**Autenticacao** | **string** | Código de autenticação registrado pelo canal | [optional] 
**ObservacaoLancamento** | **string** | Observação do lançamento | [optional] 
**DescricaoObservacaoComplementar** | **string** | Observação complementar PLD | [optional] 
**NumeroCpfCnpjRemetente** | **string** | Numero do CPF/CNPJ do remetente | [optional] 
**NumeroCpfCnpjFavorecido** | **string** | Numero do CPF/CNPJ do favorecido | [optional] 
**DescAutenticacaoDigital** | **string** | Hash identificador de transações | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

