# Sicoob.CobrancaV3.Model.Webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdWebhook** | **long** | Identificador único do webhook | 
**Url** | **string** | URL do webhook. A URL deve ser https. | 
**CodigoTipoMovimento** | **int** | Código do tipo de movimento do webhook.         7 - Pagamento (Baixa operacional)  | 
**DescricaoTipoMovimento** | **string** | Descrição do tipo de movimento | 
**CodigoPeriodoMovimento** | **int** | Código do período de movimento - 1 - Movimento atual (D0)  | 
**DescricaoPeriodoMovimento** | **string** | Descrição do período de movimento | 
**CodigoSituacao** | **int** | Código da situação do webhook - 1 - Aguardando validação - 2 - Validado com sucesso - 3 - Inativo  | 
**DescricaoSituacao** | **string** | Descrição da situação | 
**DataHoraCadastro** | **DateTime** | Data e hora de cadastro Formato: yyyy-MM-ddTHH:mm:ss.SSSZ | 
**Email** | **string** | E-mail associado ao webhook | [optional] 
**DataHoraUltimaAlteracao** | **DateTime** | Data e hora da última alteração Formato: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] 
**DataHoraInativacao** | **DateTime** | Data e hora de inativação Formato: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] 
**DescricaoMotivoInativacao** | **string** | Descrição do motivo de inativação | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

