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
Cenário: Processar a Rotina Arquivo Cobrança Terceirizada para envio dos documentos à empresa terceirizada com informação de beneficiários que não estejam cancelados na data do processamento da rotina
	Dado uma rotina arquivo cobrança terceirizada
	E beneficiários que estejam ativos ou o responsável financeiro da família esteja ativo
	E os beneficiários em questão tenham data de cancelamento futura
	E as faturas elegíveis tenham data de vencimento inferior a data de cancelamento dos beneficiários
	Quando a rotina for processada
	Então não deverá gerar documentos relacionados a essas faturas