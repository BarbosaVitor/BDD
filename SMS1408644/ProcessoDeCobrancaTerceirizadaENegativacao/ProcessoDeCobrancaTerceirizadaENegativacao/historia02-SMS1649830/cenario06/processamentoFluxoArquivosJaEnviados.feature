#language: pt-br
Funcionalidade: 
    EU, como responsável pela controladoria,
    QUERO exportar a base de cobrança de beneficiários cancelados para a empresa terceirizada,
    PARA que esta possa realizar o processamento da cobrança e proceder com a negociação da dídiva junto ao responsável financeiro.

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO
Cenário: Processar a Rotina Arquivo Cobrança Terceirizada para envio dos documentos à empresa terceirizada com beneficiários que tem arquivos já enviados à terceirizada
	Dado uma rotina arquivo cobrança terceirizada
	E os beneficiários tenham faturas de mensalidade ou contribuição elegíveis para enviar à terceirizada
	E as faturas já tenham sido processadas em alguma rotina anterior
	Quando a rotina for processada
	Então não deverá gerar documentos relacionados a essas faturas