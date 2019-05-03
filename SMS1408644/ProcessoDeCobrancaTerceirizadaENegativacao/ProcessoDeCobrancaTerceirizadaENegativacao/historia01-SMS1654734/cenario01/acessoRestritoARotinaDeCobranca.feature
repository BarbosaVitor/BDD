#language: pt-br
Funcionalidade: Acesso à rotina de cobrança de acordo com o grupo de segurança do usuário
	EU, como responsável pela controladoria,
	QUERO que o acesso a rotina de cobrança terceirizada seja restrito à área,
	PARA que eu possa definir os usuários que terão permissão de cancelar documentos enviados para a empresa de cobrança, de forma manual.

@VERSAO_3.52
Cenário: Restringir o acesso ao usuário à rotina de cobrança
	Dado um usuário sem permissão de acesso a Rotina Arquivo Cobrança Tercerizada
	Quando for acessado o módulo CONTROLE FINANCEIRO
	E acessar a carga de Documentos
	Então não será possível visualizar a carga da Rotina Arquivo Cobrança Terceirizada 
    E suas informações a respeito da cobrança terceirizada
