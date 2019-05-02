#language: pt-br
Funcionalidade: Realizar desconto de valores referentes a empréstimos negociados com a operadora
	EU, como responsável pelo pagamento da rede credenciada
	QUERO poder realizar a retenção de rendimentos de prestadores
	PARA que seja possível descontar valores referentes a empréstimos negociados com a operadora.
#VERSÃO 3.52
@FLUXO_PRINCIPAL
    Cenário: Credenciado com dois pagamentos na competência onde o primeiro atinge o valor total do benefício
    Dado que existe um credenciado que deve pagar um percentual do valor a operadora
| Id | PercentualDeRetencao | LimiteDeValorRetido |
| 01 | 20                   | 200                 |
    Quando for realizado o faturamento do primeiro PEG
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 2.000,00         | 200,00       | 1.800,00    | 164,39         | 219,66         | 1.415,95     |
    Então deverá repassar para o credenciado descontando o valor negociado
| Id | PercentualDeRetencao | ValorRetido | ValorLiquidoRepassado | ValorRemanescente |
| 01 | 20                   | 283,18      | 1.215,95              | 0,00              |
    E ao realizar o faturamento do segundo PEG 
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 3.500,00         | 500,00       | 3.000,00    | 245,82         | 328,48         | 2.425,70     |
    Então não deverá ser gerado nenhum desconto referente a emprestimo consignado pois o valor mensal já foi descontado no primeiro faturamento
| Id | PercentualDeRetencao | ValorRetido | ValorLiquidoRepassado | ValorRemanescente |
| 01 | 20                   | 0,00        | 2.425,70              | 0,00              |