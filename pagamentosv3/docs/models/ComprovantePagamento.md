# Sicoob.PagamentosV3.Model.ComprovantePagamento

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NomeAgencia** | **string** | Nome da agência onde o pagamento foi realizado. | 
**NumeroLinhaDigitavel** | **string** | Número da linha digitável do boleto formatado com 47 posições e 54 caracteres. | 
**NumeroInstituicaoEmissora** | **decimal** | Número da instituição financeira emissora do boleto. | 
**NomeInstituicaoEmissora** | **string** | Nome da instituição financeira emissora do boleto. | 
**DataVencimento** | **DateOnly** | Data de vencimento do boleto. Formato: yyyy-MM-dd  | 
**ValorBoleto** | **double** | Valor nominal do boleto. | 
**ValorAbatimentoDesconto** | **double** | Valor de abatimento e de desconto do boleto | 
**ValorMultaMora** | **double** | Valor da multa e de juros/mora do boleto. | 
**ValorPagamento** | **double** | Valor do pagamento do boleto. | 
**DataPagamento** | **DateOnly** | Data da efetivação do pagamento. Formato: yyyy-MM-dd  | 
**SituacaoPagamento** | **string** | Situação do pagamento do boleto.  - Rejeitado - Agendado - Efetivado  | 
**DescricaoDetalheSituacao** | **string** | Descrição detalhada da situação do pagamento. | 
**DataHoraCadastro** | **DateTime** | Data e hora de cadastro do agendamento/pagamento. Formato: yyyy-MM-ddTHH:mm:ss.SSSZ (Conforme especificação RFC-3339 com uso de timezone UTC)  | 
**AceitaValorDivergente** | **bool** | Entre o agendamento e o pagamento, o boleto poderá sofrer alterações pelo benificiário. Autoriza o pagamento com o valor divergente do agendado? | 
**DescricaoOuvidoria** | **string** | Descrição das informações da ouvidoria do Sicoob. | 
**DescricaoTituloComprovante** | **string** | Descreve o boleto que deve ser utilizado no comprovante.  - AGENDAMENTO DE BOLETO - PAGAMENTO DE BOLETO - PAGAMENTO REJEITADO - PAGAMENTO CANCELADO - AGENDAMENTO DE BOLETO VLB - PAGAMENTO DE BOLETO VLB - PAGAMENTO VLB REJEITADO - PAGAMENTO VLB CANCELADO  | 
**IdPagamento** | **long** | Número de identificação do agendamento no SISBR. | 
**NumeroAgencia** | **string** | Número da agência onde o pagamento foi realizado. | [optional] 
**NumeroConta** | **long** | Número da Conta onde será realizado o débito para o pagamento. | [optional] 
**NomeProprietarioContaCorrente** | **string** | Nome do propietário da conta onde o pagamento foi ou será debitado. | [optional] 
**NumeroCpfCnpjBeneficiario** | **string** | Número do CPF/CNPJ do beneficiário do boleto. | [optional] 
**NomeRazaoSocialBeneficiario** | **string** | Nome Razão Social do beneficiário do boleto. | [optional] 
**NomeFantasiaBeneficiario** | **string** | Nome Fantasia do beneficiário do boleto. | [optional] 
**NumeroCpfCnpjBeneficiarioFinal** | **string** | Número do CPF/CNPJ do beneficiário final (antigo sacador avalista) do boleto. | [optional] 
**NomeRazaoSocialBeneficiarioFinal** | **string** | Nome Razão Social do beneficiário final (antigo sacador avalista) do boleto. | [optional] 
**NomeFantasiaBeneficiarioFinal** | **string** | Nome Fantasia do beneficiário final (antigo sacador avalista) do boleto. | [optional] 
**NumeroCpfCnpjPagador** | **string** | Número do CPF/CNPJ do pagador do boleto. | [optional] 
**NomeRazaoSocialPagador** | **string** | Razão Social do Pagador do boleto | [optional] 
**NomeFantasiaPagador** | **string** | Nome Fantasia do pagador do boleto. | [optional] 
**NossoNumero** | **string** | Número identificador do boleto. | [optional] 
**NumeroDocumento** | **string** | Número identificador do boleto no sistema do beneficiário. | [optional] 
**DescricaoObservacao** | **string** | Descrição da observação informada no pagamento. | [optional] 
**NumeroAutenticacaoPagamento** | **string** | Identificador único de autenticação do pagamento no SISBR. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

