# Sicoob.Pix.Model.PayloadLocationCompleta
Identificador da localização do payload completo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Identificador da location a ser informada na criação da cobrança . | [readonly] 
**Location** | **string** | Localização do Payload a ser informada na criação da cobrança. | [readonly] 
**TipoCob** | **string** |  | 
**Criacao** | **DateTime** | Data e hora em que a location foi criada. Respeita RFC 3339. | [readonly] 
**Brcode** | **string** | QRcode no formato EMV, especificado pelo padrão adotado pelo BACEN denominado de &#x60;BR Code&#x60;. | 
**Txid** | **string** | # Identificador da transação  O campo txid determina o identificador da transação. O objetivo desse campo é ser um elemento que possibilite ao PSP do recebedor apresentar ao usuário recebedor a funcionalidade de conciliação de pagamentos.  Na pacs.008, é referenciado como &#x60;TransactionIdentification &lt;txId&gt;&#x60; ou &#x60;idConciliacaoRecebedor&#x60;.  Em termos de fluxo de funcionamento, o txid é lido pelo aplicativo do PSP do pagador e,  depois de confirmado o pagamento, é enviado para o SPI via pacs.008.  Uma pacs.008 também é enviada ao PSP do recebedor, contendo, além de todas as informações usuais  do pagamento, o txid. Ao perceber um recebimento dotado de txid, o PSP do recebedor está apto a se comunicar com o usuário recebedor,  informando que um pagamento específico foi liquidado.  O txid é criado exclusivamente pelo usuário recebedor e está sob sua responsabilidade. O txid, no contexto de representação de uma cobrança, é único por CPF/CNPJ do usuário recebedor. Cabe ao  PSP recebedor validar essa regra na API Pix.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

