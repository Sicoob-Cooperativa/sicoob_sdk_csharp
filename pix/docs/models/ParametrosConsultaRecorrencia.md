# Sicoob.Pix.Model.ParametrosConsultaRecorrencia
Parâmetros utilizados para a realização de uma consulta de recorrências.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Paginacao** | [**Paginacao**](Paginacao.md) |  | 
**Inicio** | **DateTime** | Data inicial utilizada na consulta. Respeita RFC 3339. | [optional] 
**Fim** | **DateTime** | Data de fim utilizada na consulta. Respeita RFC 3339. | [optional] 
**Cpf** | **string** |  | [optional] 
**Cnpj** | **string** |  | [optional] 
**LocationPresente** | **bool** | Filtro pela existência de location vinculada. | [optional] 
**Status** | **string** | Filtro pelo status das recorrências. | [optional] 
**Recebedor** | [**Recebedor**](Recebedor.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

