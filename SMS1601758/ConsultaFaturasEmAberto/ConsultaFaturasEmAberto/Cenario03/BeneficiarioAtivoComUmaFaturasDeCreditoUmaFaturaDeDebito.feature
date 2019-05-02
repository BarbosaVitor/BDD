#language: pt-br
Funcionalidade: Beneficiário ativo com uma faturas de crédito uma fatura de débito
	EU como responsável pela análise de crédito para empréstimos
	QUERO saber o saldo devedor do titular 
	PARA consultar de faturas em aberto
#VERSAO 3.52
@FLUXO_ALTERNATIVO
Cenário: Consultar o saldo devedor de um beneficiário com duas faturas em aberto.
Dado um beneficiário titular ativo com duas faturas
E uma de crédito
E uma de débito
	| Id | MatriculaFuncional | Nome            | Cpf           | Modulos                           | Plano       |
	| 1  | 00123456           | "JOAO DA SILVA" | "79956013013" | "1 - MSI - METRUS SAUDE INTEGRAL" | "1 – Metro" |
Quando for consultado o saldo passando como parâmetros de entrada
	| Id | CodigoDoPlano | MatriculaFuncional | Cpf           | DataReferencia |
	| 1  | 1             | "00123456"         | "79956013013" | "2019-02-25"   |
Então deverá ser retornado
	| Id | CodigoDoPlano | MatriculaFuncional | Nome            | Saldo | Juros | Multa | Correcao | Total  | Faturas |
	| 1  | 1             | "00123456"         | "JOÃO DA SILVA" | 800   | 4.54  | 16.35 | 0.54     | 821.43 | []      |
E as Faturas
	| IdFaturas | NumeroFatura | Parcela | Vencimento   | Saldo | Juros | Multa | Correcao | Total   | Modulos |
	| 1         | 85697        | 25      | "2019-01-25" | 1000  | 5.44  | 20.1  | 0.65     | 1026.19 | [1]     |
	| 2         | 78594        | 03      | "2019-01-31" | -200  | -0.9  | -3.75 | -0.11    | -204.76 | [2]     |
E os Modulos
	| IdModulos | DescricaoModulo               | Tipo          | Competencia  | NomeBeneficiario |
	| 1         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "JOAO DA SILVA"  |
	| 1         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "MARIA DA SILVA" |
	| 2         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2018-12-01" | "JOAO DA SILVA"  |