# Sicoob.CobrancaV3.Model.WebhookSolicitacoesWebhookSolicitacoesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CodigoWebhookSituacao** | **int** | Código da situação do webhook - 1 - Aguardando validação - 2 - Validado com sucesso - 3 - Inativo  | 
**DescricaoWebhookSituacao** | **string** | Descrição da situação do webhook | 
**CodigoSolicitacaoSituacao** | **int** | Código da situação da solicitação do webhook.   - 2 - Aguardando envio   - 3 - Enviado com sucesso   - 6 - Erro no envio  | 
**DescricaoSolicitacaoSituacao** | **string** | Descrição da situação da solicitação | 
**CodigoTipoMovimento** | **int** | Código do tipo de movimento do webhook.   7 - Pagamento (Baixa operacional)  | 
**DescricaoTipoMovimento** | **string** | Descrição do tipo de movimento | 
**CodigoPeriodoMovimento** | **int** | Código do período de movimento - 1 - Movimento atual (D0)  | 
**DescricaoPeriodoMovimento** | **string** | Descrição do período de movimento | 
**DataHoraCadastro** | **DateTime** | Data e hora de cadastro Formato: yyyy-MM-ddTHH:mm:ss.SSSZ | 
**ValidacaoWebhook** | **bool** | Indica se a solicitação é uma validação da url webhook | 
**DescricaoErroProcessamento** | **string** | Descrição do erro de processamento da solicitação | [optional] 
**NossoNumero** | **long** | Número que identifica o boleto de cobrança no Sisbr. | [optional] 
**CodigoBarras** | **string** | Número de código de barras do boleto com 44 posições. | [optional] 
**WebhookNotificacoes** | [**List&lt;WebhookSolicitacoesWebhookSolicitacoesInnerWebhookNotificacoesInner&gt;**](WebhookSolicitacoesWebhookSolicitacoesInnerWebhookNotificacoesInner.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

