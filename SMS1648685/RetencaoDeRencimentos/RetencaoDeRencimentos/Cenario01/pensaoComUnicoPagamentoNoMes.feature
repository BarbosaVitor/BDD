#language: pt-br
Funcionalidade: Realizar o repasse de um valor parametrizado para um credenciado com um único pagamento no mês
	EU, como responsável pelo pagamento da rede credenciada
	QUERO poder realizar a retenção de rendimentos de prestadores
	PARA atender a determinação judicial de pensão alimentícia
#VERSAO 3.52
@FLUXO_PRINCIPAL
	Cenário: Credenciado com um único pagameto no mês
	Dado um credenciado que deve pagar um valor mensal de pensão alimentícia
| Id | RepasseDaPensaoAlimenticia |
| 01 | 1.800,00                   |
	Quando  for realizado o faturamento do pagamento de um PEG
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 7.000,00         | 200,00       | 6.800,00    | 621,04         | 829,86         | 5.349,10     |
	Então deverá ser gerado o repasse referente a pensão alimentícia, gerando para o credenciado o valor líquido de R$ 3.549,10.
| Id | RepasseDaPensaoAlimenticia | ValorLiquido |
| 01 | 1.800,00                   | 3.549,10     |