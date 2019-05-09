#language: pt-br
Funcionalidade: Processamento da rotina arquivo cobrança terceirizada

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO

Esquema do Cenário: Tendo uma rotina documento processada
Cenário: Faturas que não sejam de mensalidade ou contribuição social
	Dado uma rotina arquivo cobrança terceirizada
	E com faturas diferentes do tipo mensalidade ou contribuição social
	Quando processar a rotina arquivo
	Então deverá gerar os documentos referentes as faturas, independete da quantidade de competências inadimplentes