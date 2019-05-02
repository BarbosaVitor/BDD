#language: pt-br
Funcionalidade: Beneficiário ativo com uma fatura em aberto
	EU como responsável pela análise de crédito para empréstimos
	QUERO saber o saldo devedor do titular 
	PARA consultar de faturas em aberto
#VERSAO 3.52
@FLUXO_PRINCIPAL
Cenário: Consultar o saldo devedor de um beneficiário com apenas uma fatura em aberto.
Dado um beneficiário titular com apenas uma fatura em aberto
	| Id | MatriculaFuncional | Nome            | Cpf           | Modulos                           | Plano       |
	| 1  | 00123456           | "JOAO DA SILVA" | "79956013013" | "1 - MSI - METRUS SAUDE INTEGRAL" | "1 – Metro" |
Quando for consultado o saldo devedor
	| Id | CodigoDoPlano | MatriculaFuncional | Cpf           | DataReferencia |
	| 1  | 1             | "00123456"         | "79956013013" | "2019-02-25"   |
	| 2  | 1             | null               | "79956013013" | "2019-02-25"   |
	| 3  | 1             | "00123456"         | null          | "2019-02-25"   |
Então o serviço deverá retornar 
	| Id | CodigoDoPlano | MatriculaFuncional | Nome            | Saldo  | Juros | Multa | Correcao | Total  | Faturas |
	| 1  | 1             | "00123456"         | "JOAO DA SILVA" | 123.45 | 1.5   | 10.05 | 22.35    | 157.35 | []      |
E a Fatura
	| IdFaturas | NumeroFatura | Parcela | Vencimento   | Saldo  | Juros | Multa | Correcao | Total  | Modulos |
	| 1         | 98765        | 25      | "2019-01-25" | 123.45 | 1.5   | 10.05 | 22.35    | 157.35 | []      |
E os Modulos desta fatura
	| IdModulos | DescricaoModulo                   | Tipo          | Competencia  | NomeBeneficiario |
	| 1         | "1 - MSI - METRUS SAUDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "JOAO DA SILVA"  |
	| 1         | "1 - MSI - METRUS SAUDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "MARIA DA SILVA" |