#language: pt
Funcionalidade: Processamento da rotina arquivo cobrança terceirizada

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA_POS_RETORNO
@FLUXO_ALTERNATIVO

Esquema do Cenário: Q
Cenário: Faturas inadimplentes 
	Dado rotina arquivo cobrança terceirizada
	E tipo da rotina "TERCEIRIZADA"
	E tipo do arquivo "REMESSA"
	Quando a rotina arquivo for processada
	Então serão gerados documentos referentes as cobranças na quantidade de competências marcadas na rotina arquivo ao qual está vinculada
