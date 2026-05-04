# Sicoob.Pix.Model.RecorrenciaGerada
Atributos de Configuração de Recorrência

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vinculo** | [**DescriODoObjetoDaRecorrNcia**](DescriODoObjetoDaRecorrNcia.md) |  | 
**Calendario** | [**InformaEsSobreCalendRioDaRecorrNcia**](InformaEsSobreCalendRioDaRecorrNcia.md) |  | 
**Status** | **string** |  | 
**PoliticaRetentativa** | **string** |  | 
**Atualizacao** | [**List&lt;HistRicoDeStatusInner2&gt;**](HistRicoDeStatusInner2.md) | Histórico das mudanças de status da recorrência. | 
**Valor** | [**RecorrenciaBaseValor**](RecorrenciaBaseValor.md) |  | [optional] 
**Encerramento** | [**DetalhamentoDoEncerramentoDaRecorrNcia**](DetalhamentoDoEncerramentoDaRecorrNcia.md) |  | [optional] 
**Ativacao** | [**DadosRelacionadosConfirmaODaAtivaODaRecorrNcia**](DadosRelacionadosConfirmaODaAtivaODaRecorrNcia.md) |  | [optional] 
**IdRec** | **string** | # Identificador da Recorrência  Regra de formação: - RAxxxxxxxxyyyyMMddkkkkkkkkkkk (29 caracteres; \&quot;case sensitive\&quot;, isso é, diferencia letras maiúsculas e minúsculas), sendo:   - \&quot;R\&quot;:  fixo (1 caractere). \&quot;R\&quot; para a recorrência criada dentro do Pix;   - \&quot;A\&quot;: identificação da possibilidade de novas tentativas, sendo possíveis os valores \&quot;R\&quot; ou \&quot;N\&quot; (1 caractere). \&quot;R\&quot; caso a recorrência permita novas tentativas de pagamento pós vencimento, ou \&quot;N\&quot; caso não permita novas tentativas.   - \&quot;xxxxxxxx\&quot;:  identificação do agente que presta serviço para o usuário recebedor que gerou o &lt;Id&gt;, podendo ser: o ISPB do participante direto, o ISPB do participante indireto ou os 8 primeiros dígitos do CNPJ do prestador de serviço de iniciação (8 caracteres numéricos [0-9]);   - \&quot;yyyyMMdd\&quot;:  data (8 caracteres) de criação da recorrência;   - \&quot;kkkkkkkkkkk\&quot;: sequencial criado pelo agente que gerou o &lt;Id&gt; (11 caracteres alfanuméricos [a-z|A-Z|0-9]). Deve ser único dentro de cada \&quot;yyyyMMdd\&quot;.  Dessa forma, o ID da recorrência deve ser formado de acordo com um dos tipos a seguir: - \&quot;RRxxxxxxxxyyyyMMddkkkkkkkkkkk\&quot;; para recorrência criada dentro do Pix e que permite novas tentativas de pagamento pós vencimento; ou - \&quot;RNxxxxxxxxyyyyMMddkkkkkkkkkkk\&quot;; para recorrência criada dentro do Pix e que não permite novas tentativas de pagamento pós vencimento.” | [optional] 
**Recebedor** | [**RecorrenciaGeradaAllOfRecebedor**](RecorrenciaGeradaAllOfRecebedor.md) |  | [optional] 
**Pagador** | [**RecorrenciaGeradaAllOfPagador**](RecorrenciaGeradaAllOfPagador.md) |  | [optional] 
**Autorizacao** | [**AutorizacaoRecorrenciaGerada**](AutorizacaoRecorrenciaGerada.md) |  | [optional] 
**Loc** | [**LocationDoPayloadCompleta**](LocationDoPayloadCompleta.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

