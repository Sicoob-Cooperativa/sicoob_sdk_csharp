# Sicoob.Pix.Model.CobVGerada
Dados criados ou alterados da cobrança com vencimento via API Pix

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devedor** | [**DadosDevedorDevedor**](DadosDevedorDevedor.md) |  | 
**Recebedor** | [**DadosComplementaresPessoa**](DadosComplementaresPessoa.md) | O objeto recebedor organiza as informações sobre o credor da cobrança. | 
**Chave** | **string** | # Formato do campo chave  * O campo chave determina a chave Pix registrada no DICT que será utilizada para a cobrança. Essa chave será lida pelo aplicativo do PSP do pagador para consulta ao DICT, que retornará a informação que identificará o recebedor da cobrança. * Os tipos de chave podem ser: telefone, e-mail, cpf/cnpj ou EVP. * O formato das chaves pode ser encontrado na seção \&quot;Formatação das chaves do DICT no BR Code\&quot; do [Manual de Padrões para iniciação do Pix](https://www.bcb.gov.br/estabilidadefinanceira/pagamentosinstantaneos).  | 
**Calendario** | [**CalendRio1**](CalendRio1.md) |  | 
**Txid** | **string** | # Identificador da transação  O campo txid determina o identificador da transação. O objetivo desse campo é ser um elemento que possibilite ao PSP do recebedor apresentar ao usuário recebedor a funcionalidade de conciliação de pagamentos.  Na pacs.008, é referenciado como &#x60;TransactionIdentification &lt;txId&gt;&#x60; ou &#x60;idConciliacaoRecebedor&#x60;.  Em termos de fluxo de funcionamento, o txid é lido pelo aplicativo do PSP do pagador e,  depois de confirmado o pagamento, é enviado para o SPI via pacs.008.  Uma pacs.008 também é enviada ao PSP do recebedor, contendo, além de todas as informações usuais  do pagamento, o txid. Ao perceber um recebimento dotado de txid, o PSP do recebedor está apto a se comunicar com o usuário recebedor,  informando que um pagamento específico foi liquidado.  O txid é criado exclusivamente pelo usuário recebedor e está sob sua responsabilidade. O txid, no contexto de representação de uma cobrança, é único por CPF/CNPJ do usuário recebedor. Cabe ao  PSP recebedor validar essa regra na API Pix.  | 
**Revisao** | **int** | # O campo &#x60;revisao&#x60;  Denota a revisão da cobrança.  Sempre começa em zero. Sempre varia em acréscimos de 1.  O incremento em uma cobrança deve ocorrer sempre que um objeto da cobrança em questão for alterado. O campo &#x60;loc&#x60; é uma exceção a esta regra.  Se em uma determinada alteração em uma cobrança, o único campo alterado for o campo &#x60;loc&#x60;, então esta operação não incrementa a revisão da cobrança.  O campo &#x60;loc&#x60; não ocasiona uma alteração na cobrança em si. Não é necessário armazenar histórico das alterações do campo &#x60;loc&#x60; para uma determinada cobrança. Para os outros campos da cobrança, registra-se histórico.  | 
**Status** | **string** |  | 
**Valor** | [**CobVValor**](CobVValor.md) |  | 
**SolicitacaoPagador** | **string** | O campo solicitacaoPagador, opcional, determina um texto a ser apresentado ao pagador para que ele possa digitar uma informação correlata, em formato livre, a ser enviada ao recebedor. Esse texto será preenchido, na pacs.008, pelo PSP do pagador, no campo RemittanceInformation &lt;RmtInf&gt;. O tamanho do campo &lt;RmtInf&gt; na pacs.008 está limitado a 140 caracteres. | [optional] 
**InfoAdicionais** | [**List&lt;InformaEsAdicionaisInner&gt;**](InformaEsAdicionaisInner.md) | Cada respectiva informação adicional contida na lista (nome e valor) deve ser apresentada ao pagador. | [optional] 
**Loc** | [**PayloadLocation**](PayloadLocation.md) |  | [optional] 
**Brcode** | **string** | Esse é o conteúdo do brcode da cobrança, esse conteúdo pode ser convertido em uma imagem qrcode. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

