# Sicoob.PagamentosV3.Model.BoletoConsulta

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumeroInstituicaoEmissora** | **decimal** | Número da instituição financeira emissora do boleto. | 
**NomeInstituicaoEmissora** | **string** | Nome da instituição financeira emissora do boleto. | 
**CodigoBarras** | **string** | Número de código de barras do boleto com 44 posições. | 
**NumeroLinhaDigitavel** | **string** | Número da linha digitável do boleto com 47 posições. | 
**DataVencimentoBoleto** | **DateOnly** | Data de vencimento do Boleto. Formato: yyyy-MM-dd  | 
**ValorBoleto** | **double** | Valor nominal do Boleto. | 
**ValorAbatimentoDesconto** | **double** | Valor de abatimento e de desconto do boleto. | 
**ValorMultaMora** | **double** | Valor da multa e de juros/mora. | 
**ValorPagamento** | **double** | Valor do pagamento. | 
**DataPagamento** | **DateOnly** | Data do pagamento. Exemplo: 2022-07-30  | 
**PermiteAlterarValor** | **bool** | Identificador que determina se o usuário permite efetivar o pagamento caso o valor do boleto seja alterado pelo beneficiário. | 
**ConsultaEmContingencia** | **bool** | Indica se a consulta está em modo de contingência, operando sem comunicação com a Núclea. | 
**DescricaoInstrucaoValorMinMax** | **string** | Instruções para valores mínimo e máximo | 
**BloquearPagamento** | **bool** | Identificador de pagamento não permitido. Se verdadeiro não submeter o pagamento do boleto. | 
**TipoPessoaBeneficiario** | **string** | Tipo de pessoa beneficiário. F-Pessoa Física e J-Pessoa Jurídica. | [optional] 
**NumeroCpfCnpjBeneficiario** | **string** | Número do CPF/CNPJ do beneficiário. | [optional] 
**NomeRazaoSocialBeneficiario** | **string** | Nome Razão Social do beneficiário. | [optional] 
**NomeFantasiaBeneficiario** | **string** | Nome Fantasia do beneficiário. | [optional] 
**TipoPessoaBeneficiarioFinal** | **string** | Tipo de pessoa do beneficiário final (antigo sacador avalista). 0-Isento / Não Informado, 1-CPF, 2-CNPJ, 3-PIS/PASEP, 9-Outros, F-Pessoa Física e  J-Pessoa Jurídica. | [optional] 
**NumeroCpfCnpjBeneficiarioFinal** | **string** | Número do CPF/CNPJ do beneficiário final (antigo sacador avalista). | [optional] 
**NomeRazaoSocialBeneficiarioFinal** | **string** | Nome/Razão Social do beneficiário final (antigo sacador avalista). | [optional] 
**NomeFantasiaBeneficiarioFinal** | **string** | Nome Fantasia do beneficiário final (antigo sacador avalista). | [optional] 
**TipoPessoaPagador** | **string** | Tipo de pessoa do pagador. F-Pessoa Física e J-Pessoa Jurídica. | [optional] 
**NumeroCpfCnpjPagador** | **string** | Número do CPF/CNPJ do pagador. | [optional] 
**NomeRazaoSocialPagador** | **string** | Razão Social do Pagador. | [optional] 
**NomeFantasiaPagador** | **string** | Nome Fantasia do pagador. | [optional] 
**DataLimitePagamentoBoleto** | **DateOnly** | Data limite para pagamento do Boleto. Formato: yyyy-MM-dd  | [optional] 
**CodigoEspecieDocumento** | **decimal** | Código espécie do documento ( 1  &#x3D;  CH Cheque 2  &#x3D;  DM Duplicata Mercantil 3  &#x3D;  DMI Duplicata Mercantil p/ Indicação 4  &#x3D;  DS Duplicata de Serviço 5  &#x3D;  DSI Duplicata de Serviço p/ Indicação 6  &#x3D;  DR Duplicata Rural 7  &#x3D;  LC Letra de Câmbio 8  &#x3D;  NCC Nota de Crédito Comercial 9  &#x3D;  NCE Nota de Crédito a Exportação 10  &#x3D;  NCI Nota de Crédito Industrial 11  &#x3D;  NCR Nota de Crédito Rural 12  &#x3D;  NP Nota Promissória 13  &#x3D;  NPR Nota Promissória Rural 14  &#x3D;  TM Triplicata Mercantil 15  &#x3D;  TS Triplicata de Serviço 16  &#x3D;  NS Nota de Seguro 17  &#x3D;  RC Recibo 18  &#x3D;  FAT Fatura 19  &#x3D;  ND Nota de Débito 20  &#x3D;  AP Apólice de Seguro 21  &#x3D;  ME Mensalidade Escolar 22  &#x3D;  PC Parcela de Consórcio 23  &#x3D;  NF Nota Fiscal 24  &#x3D;  DD Documento de Dívida 25  &#x3D;  Cédula de Produto RuralC015 26  &#x3D;  Warrant 27  &#x3D;  Dívida Ativa de Estado 28  &#x3D;  Dívida Ativa de Município 29  &#x3D;  Dívida Ativa da União 30  &#x3D;  Encargos condominiais 31  &#x3D;  CC Cartão de Crédito 32  &#x3D;  BDP –Boleto de Proposta 99  &#x3D;  Outros) | [optional] 
**CodigoSituacaoBoletoPagamento** | **string** | Código da situação de pagamento do boleto. (01-Boleto já baixado, 02-Boleto bloqueado para pagamento, 03-Boleto encontrado e cliente beneficiário inapto na instituição emissora do título, 04-Boleto encontrado na base e cliente Beneficiário sem cadastro, 05-Boleto encontrado e cliente beneficiário em análise na instituição emissora do título, 06-Boleto excedeu o limite de pagamentos parciais, 07-Baixa operacional integral já registrada, 08-Baixa operacional já registrada para título que não permite pagamento parcial, 09-Boleto excedeu o valor de saldo para pagamento parcial para o tipo de modelo de cálculo 04, 10-Boleto encontrado e cliente beneficiário inapto em instituição diferente da emissora, 11-Boleto encontrado e cliente beneficiário em análise em instituição diferente da emissora e 12-Boleto encontrado e cliente beneficiário apto). | [optional] 
**NossoNumero** | **string** | Número identificador do boleto. | [optional] 
**NumeroDocumento** | **string** | Número identificador do boleto no sistema do beneficiário. | [optional] 
**IdentificadorConsulta** | **string** | Identificador da consulta do boleto, deverá ser enviado no serviço de pagamento (/pagamentos/{codigoBarras}/pagar). | [optional] 
**DescricaoInstrucaoDesconto1** | **string** | Instruções para desconto 1. | [optional] 
**DescricaoInstrucaoDesconto2** | **string** | Instruções para desconto 2. | [optional] 
**DescricaoInstrucaoDesconto3** | **string** | Instruções para desconto 3. | [optional] 
**MensagemBloqueioPagamento** | **string** | Mensagem referente ao motivo pelo qual deve-se bloquer o pagamento. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

