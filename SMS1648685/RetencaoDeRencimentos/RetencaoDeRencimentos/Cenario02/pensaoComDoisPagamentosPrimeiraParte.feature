#language: pt-br
Funcionalidade: Realizar o repasse de um valor parametrizado para um credenciado com dois pagamentos no mês, sendo que o primeiro pagamento já reteve o valor necessário
    EU, como responsável pelo pagamento da rede credenciada
    QUERO poder realizar a retenção de rendimentos de prestadores
    PARA atender a determinação judicial de pensão alimentícia
#VERSÃO 3.52
@FLUXO_PRINCIPAL
    Cenário: Credenciado com dois pagamentos na competência onde o primeiro atinge o valor total do benefício
    Dado que existe um credenciado que deve pagar um valor de pensão alimentícia
| Id | RepasseDaPensaoAlimenticia |
| 01 | 1.800,00                   |
    Quando for realizado o faturamento do primeiro PEG
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 7.000,00         | 200,00       | 6.800,00    |    621,04    |    829,86    |  5.349,10  |
    Então deverá repassar para o credenciado descontando o valor da pensão alimentícia
| Id | RepasseDaPensaoAlimenticia | ValorLiquido |
| 01 | 1.800,00                   | 3.549,10     |
    E ao realizar o faturamento do segundo PEG 
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 3.500,00         | 500,00       | 3.000,00    | 245,82         | 328,48         | 2.425,70     |
    E não deverá ser gerado nenhum desconto referente a pensão alimentícia pois o valor mensal já foi descontado no primeiro faturamento
| Id | RepasseDaPensaoAlimenticia | ValorLiquido |
| 01 | 0,00                       | 2.425,70     |