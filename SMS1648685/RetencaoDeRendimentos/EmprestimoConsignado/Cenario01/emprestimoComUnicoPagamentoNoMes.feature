#language: pt-br
Funcionalidade: Realizar desconto de valores referentes a empréstimos negociados com a operadora
	EU, como responsável pelo pagamento da rede credenciada
	QUERO poder realizar a retenção de rendimentos de prestadores
	PARA que seja possível descontar valores referentes a empréstimos negociados com a operadora.
#VERSÃO 3.52
@FLUXO_PRINCIPAL
	Cenário: Credenciado com um único pagameto no mês
	Dado um credenciado que deve pagar um valor a operadora 
| Id | PercentualDeRetencao | LimiteDeValorRetido |
| 01 | 10                   | 200                 |
	Quando  for realizado o faturamento do pagamento de um PEG
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 7.000,00         | 200,00       | 6.800,00    | 621,04         | 829,86         | 5.349,10     |
	Então deverá ser gerado o repasse referente a pensão alimentícia, gerando para o credenciado o valor líquido de R$ 3.549,10.
| Id | PercentualDeRetencao | ValorRetido | ValorLiquidoRepassado |
| 01 | 10                   | 534,91      | 5.149,1               |