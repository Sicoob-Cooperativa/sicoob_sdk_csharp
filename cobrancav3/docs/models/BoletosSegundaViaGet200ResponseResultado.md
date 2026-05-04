# Sicoob.CobrancaV3.Model.BoletosSegundaViaGet200ResponseResultado

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumeroCliente** | **int** | Número que identifica o contrato do beneficiário. | 
**CodigoModalidade** | **int** | Número que identifica a modalidade do boleto. - 1 - SIMPLES COM REGISTRO - 3 - CAUCIONADA - 4 - VINCULADA - 5 - CARNÊ DE PAGAMENTOS  - 8 - COBRANÇA CONTA CAPITAL | 
**CodigoEspecieDocumento** | **string** | Espécie do documento   - CH - Cheque   - DM - Duplicata Mercantil   - DMI - Duplicata Mercantil Indicação   - DS - Duplicata de Serviço   - DSI - Duplicata Serviço Indicação   - DR - Duplicata Rural   - LC - Letra de Câmbio   - NCC - Nota de Crédito Comercial   - NCE - Nota de Crédito Exportação   - NCI - Nota de Crédito Industrial   - NCR - Nota de Crédito Rural   - NP - Nota Promissória   - NPR - Nota Promissória Rural   - TM - Triplicata Mercantil   - TS - Triplicata de Serviço   - NS - Nota de Seguro   - RC - Recibo   - FAT - Fatura   - ND - Nota de Débito   - AP - Apólice de Seguro   - ME - Mensalidade Escolar   - PC - Pagamento de Consórcio   - NF - Nota Fiscal   - DD - Documento de Dívida   - CC - Cartão de Crédito   - BDP - Boleto Proposta   - OU - Outros | 
**DataEmissao** | **DateOnly** | Data de emissão do boleto. Formato: yyyy-MM-dd  | 
**NossoNumero** | **int** | Número que identifica o boleto no Sisbr. | 
**SeuNumero** | **string** | Informar o número que identifica o boleto no sistema do beneficiário. | 
**CodigoBarras** | **string** | Número de código de barras do boleto com 44 posições. | 
**LinhaDigitavel** | **string** | Número da linha digitável do boleto com 47 posições. | 
**Valor** | **double** | Valor nominal do boleto. | 
**DataVencimento** | **DateOnly** | Data de vencimento do boleto. Formato: yyyy-MM-dd  | 
**ValorAbatimento** | **double** | Valor do abatimento. | 
**NumeroParcela** | **long** | Número da parcela do boleto. | 
**Aceite** | **bool** | Identificador do aceite do boleto. | 
**TipoMulta** | **int** | Tipo de Multa.   - 0 Isento   - 1 Valor Fixo   - 2 Percentual | 
**TipoJurosMora** | **int** | Tipo de Juros de Mora - 1 Valor por dia - 2 Taxa Mensal - 3 Isento | 
**Pagador** | [**BoletosGet200ResponseResultadoPagador**](BoletosGet200ResponseResultadoPagador.md) |  | 
**TipoDesconto** | **long** | Informar o tipo de desconto a ser aplicado no boleto. - 0 Sem Desconto - 1 Valor Fixo Até a Data Informada - 2 Percentual até a data informada - 3 Valor por antecipação dia corrido - 4 Valor por antecipação dia útil - 5 Percentual por antecipação dia corrido - 6 Percentual por antecipação dia útil | 
**ValorMulta** | **double** | Valor da multa. | [optional] 
**ValorJurosMora** | **double** | Valor do Juros de Mora. | [optional] 
**BeneficiarioFinal** | [**BoletosGet200ResponseResultadoBeneficiarioFinal**](BoletosGet200ResponseResultadoBeneficiarioFinal.md) |  | [optional] 
**MensagensInstrucao** | **List&lt;string&gt;** |  | [optional] 
**PdfBoleto** | **string** | String na Base64 do PDF do Boleto. | [optional] 
**QrCode** | **string** | QRCode para pagamento com PIX | [optional] 
**NumeroContratoCobranca** | **long** | Indicar o id do contatroCobranca | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

