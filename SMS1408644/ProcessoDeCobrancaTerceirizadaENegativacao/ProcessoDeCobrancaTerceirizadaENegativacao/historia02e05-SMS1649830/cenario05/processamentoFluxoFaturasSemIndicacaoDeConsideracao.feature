#language: pt-br
Funcionalidade: Processamento da rotina arquivo cobrança terceirizada

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO

Cenário: Envio dos documentos à empresa terceirizada com faturas de mensalidade ou contribuição social
	Dado uma rotina arquivo cobrança terceirizada do tipo remessa parametrizada para envio à terceirizada
	E faturas de mensalidade ou contribuição elegíveis para enviar à terceirizada
	E esses tipos de faturas tenham o flag "considerado na inadimplência" marcado
	Quando a rotina for processada
	Então deverá gerar documentos relacionados a essas faturas