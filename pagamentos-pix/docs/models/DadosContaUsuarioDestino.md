# Sicoob.PagamentosPix.Model.DadosContaUsuarioDestino
Dados da conta de destino do lancamento. Este atributo é obrigatório apenas para o meio de iniciação MANUAL. Quando o meio de iniciação for CHAVE, os atributos deste objeto, se forem informados, serão validados com o retorno obtido na iniciação DICT (POST /pagamentos)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ispb** | **string** | Código ISPB da IF | [optional] 
**CpfCnpj** | **string** | CPF / CNPJ | [optional] 
**Nome** | **string** | Nome / Razao social | [optional] 
**Conta** | **string** | Número da conta | [optional] 
**Agencia** | **string** | Número da agencia | [optional] 
**Tipo** | **string** | Tipo da Conta | [optional] 
**BoolFavorecido** | **bool** | Indica se o destinatário é favorecido ou não. Se o campo não for passado o padrão será &#x60;false&#x60; | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

