#language: pt-br
Funcionalidade: Realizar desconto de valores referentes a empréstimos negociados com a operadora
	EU, como responsável pelo pagamento da rede credenciada
	QUERO poder realizar a retenção de rendimentos de prestadores
	PARA que seja possível descontar valores referentes a empréstimos negociados com a operadora.
#VERSAO 3.52
@FLUXO_PRINCIPAL
    Cenário: Prestador credenciado com dois pagamentos na competência onde o primeiro não atinge o valor total do empréstimo negociado
    Dado um prestador credenciado que deve pagar pensão alimentícia
| Id | PercentualDeRetencao | LimiteDeValorRetido |
| 01 | 2,5                  | 200,00              |
| 02 | 5,0                  | 320,00              |
    Quando um PEG for faturado
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 7.000,00         | 200,00       | 6.800,00    | 621,04         | 829,86         | 5.349,10     |
| 02 | 7.500,00         | 250,00       | 7.250,00    | 662,13         | 884,77         | 5.703,10     |
    Então restará ainda um valor para quitação
| Id | PercentualDeRetencao | ValorRetido | ValorLiquidoRepassado | ValorRemanescente |
| 01 | 2,5                  | 133,72      | 5215,37               | 66,28             |
| 02 | 5,0                  | 285,15      | 5.417,95              | 34,85             |
    E quando for realizado o faturamento de um segundo PEG
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 1.250,00         | 0,00         | 1.250,00    | 114,16         | 152,54         | 1.010,72     |
| 02 | 2.050,00         | 50,00        | 2.000,00    | 182,65         | 244,07         | 1.573,28     |
    Então deverá gerar um desconto referente ao empréstimo consignado ainda não quitado no mês
| Id | PercentualDeRetencao | ValorRetido | ValorLiquidoRepassado | ValorRemanescente |
| 01 | 2,5                  | 25,26       | 985,45                | 41,02             |
| 02 | 5,0                  | 78,66       | 1.538,43              | 0,00              |