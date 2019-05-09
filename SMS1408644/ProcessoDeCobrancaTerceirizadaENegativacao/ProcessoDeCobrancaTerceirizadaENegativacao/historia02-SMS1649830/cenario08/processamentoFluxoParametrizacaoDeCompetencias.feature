﻿#language: pt
Funcionalidade: 
    EU, como responsável pela controladoria,
    QUERO exportar a base de cobrança de beneficiários cancelados para a empresa terceirizada,
    PARA que esta possa realizar o processamento da cobrança e proceder com a negociação da dídiva junto ao responsável financeiro.

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO

Esquema do Cenário: Uma rotina documento processada com a quantidade de competências para cobrança igual a 1 o flag "agrupar faturas em um único documento" marcado 
Cenário: Faturas inadimplentes 
	Dado rotina arquivo cobrança terceirizada
	E tipo da rotina "TERCEIRIZADA"
	E tipo do arquivo "REMESSA"
	Quando a rotina arquivo for processada
	Então serão gerados documentos referentes as cobranças na quantidade de competências marcadas na rotina arquivo ao qual está vinculada
