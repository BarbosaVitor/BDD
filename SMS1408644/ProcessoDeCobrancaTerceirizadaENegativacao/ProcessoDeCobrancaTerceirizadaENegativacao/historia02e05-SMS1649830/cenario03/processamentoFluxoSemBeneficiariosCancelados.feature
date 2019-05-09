#language: pt-br
Funcionalidade: Processamento da rotina arquivo cobrança terceirizada

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO

Cenário: Envio dos documentos à empresa terceirizada com informação de beneficiários ativos na data do processamento da rotina
	Dado que se tenha documentos prontos para envio à empresa terceirizada
	Mas os beneficiários estão ativos ou o responsável financeiro da família está ativo
	Quando a rotina for processada
	Então não deverá gerar documentos relacionados a essas faturas