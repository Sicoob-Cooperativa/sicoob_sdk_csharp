# Sicoob.Pix.Model.CobRevisada
Dados enviados para revisão da cobrança imediata via API Pix

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chave** | **string** | # Formato do campo chave  * O campo chave determina a chave Pix registrada no DICT que será utilizada para a cobrança. Essa chave será lida pelo aplicativo do PSP do pagador para consulta ao DICT, que retornará a informação que identificará o recebedor da cobrança. * Os tipos de chave podem ser: telefone, e-mail, cpf/cnpj ou EVP. * O formato das chaves pode ser encontrado na seção \&quot;Formatação das chaves do DICT no BR Code\&quot; do [Manual de Padrões para iniciação do Pix](https://www.bcb.gov.br/estabilidadefinanceira/pagamentosinstantaneos).  | [optional] 
**SolicitacaoPagador** | **string** | O campo solicitacaoPagador, opcional, determina um texto a ser apresentado ao pagador para que ele possa digitar uma informação correlata, em formato livre, a ser enviada ao recebedor. Esse texto será preenchido, na pacs.008, pelo PSP do pagador, no campo RemittanceInformation &lt;RmtInf&gt;. O tamanho do campo &lt;RmtInf&gt; na pacs.008 está limitado a 140 caracteres. | [optional] 
**InfoAdicionais** | [**List&lt;InformaEsAdicionaisInner&gt;**](InformaEsAdicionaisInner.md) | Cada respectiva informação adicional contida na lista (nome e valor) deve ser apresentada ao pagador. | [optional] 
**Calendario** | [**CobExpiracao**](CobExpiracao.md) | Os campos aninhados sob o identificador calendário organizam informações a respeito de controle de tempo da cobrança. | [optional] 
**Devedor** | [**CobRevisadaAllOfDevedor**](CobRevisadaAllOfDevedor.md) |  | [optional] 
**Loc** | [**CobRevisadaAllOfLoc**](CobRevisadaAllOfLoc.md) |  | [optional] 
**Status** | **string** |  | [optional] 
**Valor** | [**CobVValor**](CobVValor.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

