#language: pt-br
Funcionalidade: Realizar o repasse de um valor parametrizado para um credenciado por meio de dois pagamentos
    EU, como responsável pelo pagamento da rede credenciada
    QUERO poder realizar a retenção de rendimentos de prestadores
    PARA atender a determinação judicial de pensão alimentícia
#VERSAO 3.52
@FLUXO_PRINCIPAL
    Cenário: Prestador Credenciado com dois pagamentos na competência onde o primeiro não atinge o valor total do benefício
    Dado um prestador credenciado que deve pagar pensão alimentícia
| Id | RepassePensaoAlimenticia |
| 01 | 2.500,00                 |
    Quando um PEG for faturado
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 3.250,00         | 750,00       | 2.500,00    | 204,85         | 273,73         | 2.021,42     |
    Então restará ainda um valor para quitação
| Id | RepasseDaPensaoAlimenticia | ValorLiquido |
| 01 | 2.500,00                   | 0,00         |
    E quando for realizado o faturamento de um segundo PEG
| Id | ValorApresentado | ValorGlosado | ValorAPagar | DescontoDeINSS | DescontoDeIRRF | ValorLiquido |
| 01 | 1.250,00         | 0,00         | 1.250,00    | 102,42         | 136,86         | 1.010,72     |
    E deverá gerar um desconto referente a pensão alimentícia ainda não quitado no mês
    E um valor líquido de pagamento 
| Id | RepasseDaPensaoAlimenticia | ValorLiquido |
| 01 | 478,58                     | 532,14       |