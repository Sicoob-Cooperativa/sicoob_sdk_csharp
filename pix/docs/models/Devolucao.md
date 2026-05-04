# Sicoob.Pix.Model.Devolucao

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id gerado pelo cliente para representar unicamente uma devolução. | 
**RtrId** | **string** | ReturnIdentification que transita na PACS004. | 
**Valor** | **string** | Valor a devolver. | 
**Horario** | [**DevolucaoHorario**](DevolucaoHorario.md) |  | 
**Status** | **string** | Status da devolução. | 
**Natureza** | **DevolucaoNatureza** |  | [optional] 
**Descricao** | **string** | O campo &#x60;descricao&#x60;, opcional, determina um texto a ser apresentado ao pagador contendo informações sobre a devolução. Esse texto será preenchido, na pacs.004, pelo PSP do recebedor, no campo RemittanceInformation. O tamanho do campo na pacs.004 está limitado a 140 caracteres. | [optional] 
**Motivo** | **string** | # Status da Devolução Campo opcional que pode ser utilizado pelo PSP recebedor para detalhar os motivos de a devolução ter atingido o status em questão. Pode ser utilizado, por exemplo, para detalhar o motivo de a devolução não ter sido realizada.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

