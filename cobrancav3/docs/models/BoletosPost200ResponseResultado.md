# Sicoob.CobrancaV3.Model.BoletosPost200ResponseResultado

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumeroCliente** | **int** | Número que identifica o contrato do beneficiário. | 
**CodigoModalidade** | **int** | Número que identifica a modalidade do boleto.    - 1 SIMPLES COM REGISTRO | 
**NumeroContaCorrente** | **int** | Número da Conta Corrente para crédito do boleto. | 
**CodigoEspecieDocumento** | **string** | Espécie do documento   - CH - Cheque   - DM - Duplicata Mercantil   - DMI - Duplicata Mercantil Indicação   - DS - Duplicata de Serviço   - DSI - Duplicata Serviço Indicação   - DR - Duplicata Rural   - LC - Letra de Câmbio   - NCC - Nota de Crédito Comercial   - NCE - Nota de Crédito Exportação   - NCI - Nota de Crédito Industrial   - NCR - Nota de Crédito Rural   - NP - Nota Promissória   - NPR - Nota Promissória Rural   - TM - Triplicata Mercantil   - TS - Triplicata de Serviço   - NS - Nota de Seguro   - RC - Recibo   - FAT - Fatura   - ND - Nota de Débito   - AP - Apólice de Seguro   - ME - Mensalidade Escolar   - PC - Pagamento de Consórcio   - NF - Nota Fiscal   - DD - Documento de Dívida   - BDP - Boleto Proposta   - OU - Outros | 
**DataEmissao** | **DateOnly** | Data de emissão do boleto Formato: yyyy-MM-dd  | 
**NossoNumero** | **int** | Número que identifica o boleto. | 
**SeuNumero** | **string** | Informar o número que identifica o boleto no sistema do beneficiário. | 
**CodigoBarras** | **string** | Número de código de barras do boleto com 44 posições. | 
**LinhaDigitavel** | **string** | Número da linha digitável do boleto com 47 posições. | 
**IdentificacaoEmissaoBoleto** | **int** | Identificação de Emissão do Boleto - 1 Banco Emite - 2 Cliente Emite | 
**Valor** | **double** | Valor nominal do boleto. | 
**DataVencimento** | **DateOnly** | Data de vencimento do boleto. Formato: yyyy-MM-dd  | 
**ValorAbatimento** | **double** | Valor do abatimento. | 
**TipoDesconto** | **long** | Informar o tipo de desconto a ser aplicado no boleto.     - 0 Sem Desconto     - 1 Valor Fixo Até a Data Informada     - 2 Percentual até a data informada     - 3 Valor por antecipação dia corrido     - 4 Valor por antecipação dia útil     - 5 Percentual por antecipação dia corrido     - 6 Percentual por antecipação dia útil | 
**TipoMulta** | **int** | Tipo de Multa   - 0 Isento   - 1 Valor Fixo   - 2 Percentual | 
**DataMulta** | **DateOnly** | Deve ser maior que a data de vencimento do boleto e menor ou igual que data limite de pagamento. Formato: yyyy-MM-dd | 
**ValorMulta** | **double** | Valor da multa. | 
**TipoJurosMora** | **int** | Tipo de Juros de Mora   - 1 Valor por dia   - 2 Taxa Mensal   - 3 Isento | 
**DataJurosMora** | **DateOnly** | Deve ser maior que a data de vencimento do boleto e menor ou igual que data limite de pagamento. Formato: yyyy-MM-dd | 
**ValorJurosMora** | **double** | Valor do Juros de Mora. | 
**NumeroParcela** | **long** | Número da parcela. | 
**Aceite** | **bool** | Identificador do aceite do boleto. | 
**CodigoNegativacao** | **int** | Código de Negativação do Boleto   - 2 Negativar Dias Úteis   - 3 Não Negativar | 
**CodigoProtesto** | **int** | Código de Protesto do Boleto   - 1 Protestar Dias Corridos   - 2 Protestar Dias Úteis   - 3 Não Protestar | 
**IdentificacaoBoletoEmpresa** | **string** | Destinado para uso da Empresa Cedente para identificação do Boleto | [optional] 
**IdentificacaoDistribuicaoBoleto** | **int** | Identificação de Distribuição do Boleto   - 1 Banco Distribui   - 2 Cliente Distribui | [optional] 
**DataLimitePagamento** | **DateOnly** | Data de limite para pagamento do boleto. Formato: yyyy-MM-dd  | [optional] 
**DataPrimeiroDesconto** | **DateOnly** | Data do primeiro desconto. Formato: yyyy-MM-dd  | [optional] 
**ValorPrimeiroDesconto** | **double** | Valor do primeiro desconto | [optional] 
**DataSegundoDesconto** | **DateOnly** | Data do segundo desconto Formato: yyyy-MM-dd  | [optional] 
**ValorSegundoDesconto** | **double** | Valor do segundo desconto | [optional] 
**DataTerceiroDesconto** | **DateOnly** | Data do terceiro desconto Formato: yyyy-MM-dd  | [optional] 
**ValorTerceiroDesconto** | **double** | Valor do terceiro desconto | [optional] 
**NumeroDiasNegativacao** | **int** | Número de Dias para Negativação do Boleto | [optional] 
**NumeroDiasProtesto** | **int** | Número de Dias para Protesto do Boleto | [optional] 
**QuantidadeDiasFloat** | **int** | Quantidade de Dias de Float. | [optional] 
**Pagador** | [**BoletosPost200ResponseResultadoPagador**](BoletosPost200ResponseResultadoPagador.md) |  | [optional] 
**BeneficiarioFinal** | [**BoletosPost200ResponseResultadoBeneficiarioFinal**](BoletosPost200ResponseResultadoBeneficiarioFinal.md) |  | [optional] 
**MensagensInstrucao** | **List&lt;string&gt;** |  | [optional] 
**RateioCreditos** | [**List&lt;RateioCredito&gt;**](RateioCredito.md) |  | [optional] 
**PdfBoleto** | **string** | String na Base64 do PDF do Boleto. | [optional] 
**QrCode** | **string** | QRCode para pagamento com PIX | [optional] 
**NumeroContratoCobranca** | **long** | Indicar o id do contatroCobranca | [optional] 
**DescricaoRejeicaoPix** | **string** | O motivo pelo qual não foi incluído o QRCode para pagamento com PIX. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

