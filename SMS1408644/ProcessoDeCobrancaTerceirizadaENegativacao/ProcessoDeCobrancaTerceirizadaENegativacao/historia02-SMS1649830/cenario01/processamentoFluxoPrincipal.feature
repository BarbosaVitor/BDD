﻿#language: pt
Funcionalidade: 
    EU, como responsável pela controladoria,
    QUERO exportar a base de cobrança de beneficiários cancelados para a empresa terceirizada,
    PARA que esta possa realizar o processamento da cobrança e proceder com a negociação da dídiva junto ao responsável financeiro.

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_PRINCIPAL

Esquema do Cenário: Uma rotina documento processada do tipo Cobrança Terceirizada
Cenário: Processamento da rotina arquivo cobrança terceirizada
    Dado que eu tenha documentos para cobrança para enviar à empresa terceirizada
    E uma rotina rotina arquivo cobrança terceirizada
    E seja do tipo terceirizada
    E o tipo da terceirizada seja do tipo remessa
    Quando for identificado o modelo documento relacionado ao envio para a empresa terceirizada
    E a rotina for processada
    Então deverá gerar um arquivo do tipo remessa contendo as informações dos documentos das faturas