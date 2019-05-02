#language: pt-br
Funcionalidade: Beneficiario ativo com dados diferentes do sistema
	EU como responsável pela análise de crédito para empréstimos
	QUERO saber o saldo devedor do titular 
	PARA consultar de faturas em aberto
#VERSAO 3.52
@FLUXO_ALTERNATIVO
Cenário: Consultar o saldo devedor de um beneficiário informando matrícula funcional e cpf diferentes dos cadastrados no sistema
Dado um beneficiário titular 
E uma fatura em aberto
	| Id | MatriculaFuncional | Nome            | Cpf           | Modulos                           | Plano       |
	| 1  | 00123456           | "JOAO DA SILVA" | "79956013013" | "1 - MSI - METRUS SAUDE INTEGRAL" | "1 – Metro" |
Quando for consultado 
	| Id | CodigoDoPlano | MatriculaFuncional | Cpf           | DataReferencia |
	| 1  | 1             | "123321"           | "14458764235" | "2019-02-25"   |
Então o serviço deverá retornar uma mensagem de erro