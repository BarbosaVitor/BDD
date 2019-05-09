#language: pt-br
Funcionalidade: Processamento da rotina arquivo cobrança terceirizada

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO

Cenário: Envio de documentos de remessa à empresa terceirizada com arquivos já enviados à terceirizada
	Dado uma rotina arquivo cobrança terceirizada do tipo remessa
	E os beneficiários tenham faturas de mensalidade ou contribuição elegíveis para enviar à terceirizada
	E as faturas já tenham sido processadas em alguma rotina anterior
	Quando a rotina for processada
	Então não deverá gerar documentos relacionados a essas faturas