#language: pt-br
Funcionalidade: Beneficiário cancelado no sistema mas ativo na data de referência
	EU como responsável pela análise de crédito para empréstimos
	QUERO saber o saldo devedor do titular 
	PARA consultar de faturas em aberto

@FLUXO_ALTERNATIVO
Cenário: Consultar o saldo devedor de um beneficiário que está cancelado no sistema mas ativo na data de referência
Dado um beneficiário titular que tenha uma fatura em aberto
E cancelado
Mas ativo na data de referência
	| Id | MatriculaFuncional | Nome            | Cpf           | Modulos                           | Plano       |
	| 1  | 00123456           | "JOAO DA SILVA" | "79956013013" | "1 - MSI - METRUS SAUDE INTEGRAL" | "1 – Metro" |
Quando for consultado o saldo no dia "2019-03-26"
	| Id | CodigoDoPlano | MatriculaFuncional | Cpf           | DataReferencia |
	| 1  | 1             | "00123456"         | "78856013013" | "2019-02-25"   |
Então o serviço deve retornar
	| Id | CodigoDoPlano | MatriculaFuncional | Nome            | Saldo  | Juros | Multa | Correcao | Total  | Faturas |
	| 1  | 1             | "00123456"         | "JOÃO DA SILVA" | 123.45 | 1.5   | 10.05 | 22.35    | 157.35 | []      |
E a Fatura retorna
	| IdFaturas | NumeroFatura | Parcela | Vencimento   | Saldo  | Juros | Multa | Correcao | Total  | Modulos |
	| 1         | 98765        | 25      | "2019-01-25" | 123.45 | 1.5   | 10.05 | 22.35    | 157.35 | []      |
E os Modulos retornam
	| IdModulos | DescricaoModulo               | Tipo          | Competencia  | NomeBeneficiario |
	| 1         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "JOAO DA SILVA"  |
	| 1         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "MARIA DA SILVA" |