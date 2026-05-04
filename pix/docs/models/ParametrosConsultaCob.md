# Sicoob.Pix.Model.ParametrosConsultaCob
[DEPRECADO] Parâmetros utilizados para a realização de uma consulta de cobranças.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inicio** | **DateTime** | Data inicial utilizada na consulta. Respeita RFC 3339. | 
**Fim** | **DateTime** | Data de fim utilizada na consulta. Respeita RFC 3339. | 
**Paginacao** | [**Paginacao**](Paginacao.md) |  | 
**Cpf** | **string** | Filtro pelo CPF do devedor. Não pode ser utilizado ao mesmo tempo que o CNPJ. | [optional] 
**Cnpj** | **string** | Filtro pelo CNPJ do devedor. Não pode ser utilizado ao mesmo tempo que o CPF. | [optional] 
**LocationPresente** | **bool** | Filtro pela existência de location vinculada. | [optional] 
**Status** | **string** | Filtro pelo status das cobranças. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

