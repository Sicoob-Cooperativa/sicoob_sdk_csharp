# Sicoob.Pix.Model.CobrancaRecorrenteGerada
Dados criados ou alterados da cobrança recorrente via API Pix

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Calendario** | [**CobrancaRecorrenteGeradaAllOfCalendario**](CobrancaRecorrenteGeradaAllOfCalendario.md) |  | 
**Valor** | [**ValorDaCobranARecorrente1**](ValorDaCobranARecorrente1.md) |  | 
**Recebedor** | [**DadosBancariosRecebedor**](DadosBancariosRecebedor.md) |  | 
**Status** | **string** |  | 
**Atualizacao** | [**List&lt;HistRicoDeStatusInner1&gt;**](HistRicoDeStatusInner1.md) | Histórico das mudanças de status das cobranças recorrentes. | 
**IdRec** | **string** | # Identificador da Recorrência  Regra de formação: - RAxxxxxxxxyyyyMMddkkkkkkkkkkk (29 caracteres; \&quot;case sensitive\&quot;, isso é, diferencia letras maiúsculas e minúsculas), sendo:   - \&quot;R\&quot;:  fixo (1 caractere). \&quot;R\&quot; para a recorrência criada dentro do Pix;   - \&quot;A\&quot;: identificação da possibilidade de novas tentativas, sendo possíveis os valores \&quot;R\&quot; ou \&quot;N\&quot; (1 caractere). \&quot;R\&quot; caso a recorrência permita novas tentativas de pagamento pós vencimento, ou \&quot;N\&quot; caso não permita novas tentativas.   - \&quot;xxxxxxxx\&quot;:  identificação do agente que presta serviço para o usuário recebedor que gerou o &lt;Id&gt;, podendo ser: o ISPB do participante direto, o ISPB do participante indireto ou os 8 primeiros dígitos do CNPJ do prestador de serviço de iniciação (8 caracteres numéricos [0-9]);   - \&quot;yyyyMMdd\&quot;:  data (8 caracteres) de criação da recorrência;   - \&quot;kkkkkkkkkkk\&quot;: sequencial criado pelo agente que gerou o &lt;Id&gt; (11 caracteres alfanuméricos [a-z|A-Z|0-9]). Deve ser único dentro de cada \&quot;yyyyMMdd\&quot;.  Dessa forma, o ID da recorrência deve ser formado de acordo com um dos tipos a seguir: - \&quot;RRxxxxxxxxyyyyMMddkkkkkkkkkkk\&quot;; para recorrência criada dentro do Pix e que permite novas tentativas de pagamento pós vencimento; ou - \&quot;RNxxxxxxxxyyyyMMddkkkkkkkkkkk\&quot;; para recorrência criada dentro do Pix e que não permite novas tentativas de pagamento pós vencimento.”  | 
**Txid** | **string** | # Identificador da transação  O campo txid determina o identificador da transação. O objetivo desse campo é ser um elemento que possibilite ao PSP do recebedor apresentar ao usuário recebedor a funcionalidade de conciliação de pagamentos.  Na pacs.008, é referenciado como &#x60;TransactionIdentification &lt;txId&gt;&#x60; ou &#x60;idConciliacaoRecebedor&#x60;.  Em termos de fluxo de funcionamento, o txid é lido pelo aplicativo do PSP do pagador e,  depois de confirmado o pagamento, é enviado para o SPI via pacs.008.  Uma pacs.008 também é enviada ao PSP do recebedor, contendo, além de todas as informações usuais  do pagamento, o txid. Ao perceber um recebimento dotado de txid, o PSP do recebedor está apto a se comunicar com o usuário recebedor,  informando que um pagamento específico foi liquidado.  O txid é criado exclusivamente pelo usuário recebedor e está sob sua responsabilidade. O txid, no contexto de representação de uma cobrança, é único por CPF/CNPJ do usuário recebedor. Cabe ao  PSP recebedor validar essa regra na API Pix.  | 
**InfoAdicional** | **string** | Informações adicionais da fatura. | [optional] 
**AjusteDiaUtil** | **bool** | Campo de ativação do ajuste da data prevista para liquidação para próximo dia útil caso o vencimento corrente seja um dia não útil. O PSP Recebedor deverá considerar os feriados locais com base no código município do usuário pagador. | [default to true]
**Devedor** | [**DadosDevedorRecorrenciaDevedor**](DadosDevedorRecorrenciaDevedor.md) |  | [optional] 
**Tentativas** | [**List&lt;HistRicoDeTentativasDeCobranAInner&gt;**](HistRicoDeTentativasDeCobranAInner.md) | Histórico de Tentativas de Cobrança | [optional] 
**Encerramento** | [**DetalhamentoDoEncerramentoDaCobranA**](DetalhamentoDoEncerramentoDaCobranA.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

