# Sicoob.Pix.Model.CalendRio3
Os campos aninhados sob o identificador calendário organizam informações a respeito de controle de tempo da cobrança.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Criacao** | **DateTime** | Timestamp que indica o momento em que foi criada a cobrança. Respeita o formato definido na RFC 3339. | 
**Apresentacao** | **DateTime** | Timestamp que indica o momento em que o payload JSON que representa a cobrança foi recuperado. Ou seja, idealmente, é o momento em que o usuário realizou a captura do QR Code para verificar os dados de pagamento. Respeita o formato definido na RFC 3339. | 
**Expiracao** | **int** | Tempo de vida da cobrança, especificado em segundos a partir da data de criação (Calendario.criacao)  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

