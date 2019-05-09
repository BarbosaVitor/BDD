#language: pt-br
Funcionalidade: Processamento da rotina arquivo cobrança terceirizada

@VERSAO_3.52
@CONTROLE_FINANCEIRO
@ROTINA_ARQUIVO_COBRANCA_TERCEIRIZADA
@REMESSA
@FLUXO_ALTERNATIVO

Esquema do Cenário: Uma rotina documento processada com faturas não elegíveis para a rotina arquivo cobrança terceirizada
Cenário: Processamento da rotina arquivo cobrança terceirizada com informação de beneficiários sem faturas elegíveis para a rotina
    Dado que se tenha documentos prontos para envio à empresa terceirizada
	Mas o beneficiário não possui faturas elegíveis "Abertas", "Suspensas" ou "Canceladas" até a data do processamento
    Quando a rotina for processada
    Então não deverá gerar nenhum arquivo contendo documentos para envio à terceirizada

