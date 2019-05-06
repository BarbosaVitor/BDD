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
Cenário: Processar a Rotina Arquivo Cobrança Terceirizada para envio dos documentos à empresa terceirizada com informação de beneficiários sem faturas elegíveis para a rotina
    Dado uma rotina arquivo cobrança terceirizada
	Mas o beneficiário não possui faturas elegíveis "Abertas", "Suspensas" ou "Canceladas" até a data do processamento
    Quando a rotina for processada
    Então não deverá gerar nenhum arquivo contendo documentos para envio à terceirizada