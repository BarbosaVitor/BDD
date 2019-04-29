#language: pt-br
Funcionalidade: Reter o valor de salário mínimo na pensão judicial em duas competências diferentes
    EU, como responsável pelo pagamento da rede credenciada
    QUERO poder realizar a retenção de rendimentos de prestadores
    PARA atender a determinação judicial de pensão alimentícia
#VERSAO 3.52
@FLUXO_PRINCIPAL
	Cenário: Prestador credenciado com valor de pensão alimentícial indexada ao salário mínimo
	Dado um prestador credenciado que deve pagar dois salários mínimos de pensão alimentícia
	E for parametrizado na sua decisão judiial
| Id | Competencia | ValorDoSalarioMinimo |
| 01 | 01/2017     | 937,00               |
| 02 | 01/2018     | 954,00               |
| 03 | 01/2019     | 998,00               |
	Quando for realizado o faturamento de um PEG
| Id | Competencia | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 10/2018     | 3.250,00         | 750,00       | 2.500,00    | 204,85         | 273,73         | 2.021,42     |
| 02 | 02/2019     | 7.850,00         | 125,00       | 7.725,00    | 632,99         | 845,83         | 6.246,18     |
	Então deverá ser gerado um repasse referente a pensão alimentícia para o credenciado
| Id | RepasseDaPensaoAlimenticia | ValorLiquido |
| 01 | 954,00                     | 1.067,42     |
| 02 | 998,00                     | 5.248,18     |