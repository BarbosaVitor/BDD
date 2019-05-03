#language: pt-br
Funcionalidade: 
    EU, como responsável pela controladoria,
    QUERO exportar a base de cobrança de beneficiários cancelados para a empresa terceirizada,
    PARA que esta possa realizar o processamento da cobrança e proceder com a negociação da dídiva junto ao responsável financeiro.

@VERSAO_3.52
Cenário: Processar a Rotina Arquivo Cobrança Terceirizada
    Dado uma rotina arquivo cobrança do tipo terceirizada do tipo remessa
    Quando os campos obrigatórios forem preenchidos
    E for informado o modelo documento relacionado a rotina 