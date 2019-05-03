#language: pt-br
Funcionalidade: 
    EU, como responsável pela controladoria,
    QUERO exportar a base de cobrança de beneficiários cancelados para a empresa terceirizada,
    PARA que esta possa realizar o processamento da cobrança e proceder com a negociação da dídiva junto ao responsável financeiro.

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
Cenário: Processar a Rotina Arquivo Cobrança Terceirizada
    Dado uma rotina arquivo cobrança terceirizada
    E seja do tipo terceirizada
    E o tipo da terceirizada seja do tipo remessa
    Quando forem preenchidos os campos do modelo documento relacionado a rotina
    E a rotina for processada
    Então deverá gerar um arquivo do tipo remessa contendo as informações dos documentos a serem enviados