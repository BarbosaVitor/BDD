#language: pt-br
Funcionalidade: Beneficiário ativo com duas faturas de crédito
	EU como responsável pela análise de crédito para empréstimos
	QUERO saber o saldo devedor do titular 
	PARA consultar de faturas em aberto
#VERSAO 3.52
@FLUXO_ALTERNATIVO
Cenário: Consultar o saldo devedor de um beneficiário com duas faturas em aberto.
Dado um beneficiário titular ativo
E duas faturas de crédito
	| Id | MatriculaFuncional | Nome            | Cpf           | Modulos                           | Plano       |
	| 1  | 00123456           | "JOAO DA SILVA" | "79956013013" | "1 - MSI - METRUS SAUDE INTEGRAL" | "1 – Metro" |
Quando for consultado o saldo devedor do beneficiário
	| Id | CodigoDoPlano | MatriculaFuncional | Cpf           | DataReferencia |
	| 1  | 1             | "00123456"         | "79956013013" | "2019-02-25"   |
Então o serviço deverá retornar como resposta
	| Id | CodigoDoPlano | MatriculaFuncional | Nome            | Saldo  | Juros | Multa | Correcao | Total  | Faturas |
	| 1  | 1             | "00123456"         | "JOÃO DA SILVA" | 246,90 | 3.0   | 20.10 | 44.70    | 314.70 | []      |
E as Faturas devem retornar
	| IdFaturas | NumeroFatura | Parcela | Vencimento   | Saldo  | Juros | Multa | Correcao | Total  | Modulos |
	| 1         | 98765        | 25      | "2019-01-25" | 123.45 | 1.5   | 10.05 | 22.35    | 157.35 | [1]     |
	| 2         | 98708        | 24      | "2018-12-23" | 123.45 | 1.5   | 10.05 | 22.35    | 157.35 | [2]     |
E os Modulos devem retornar
	| IdModulos | DescricaoModulo               | Tipo          | Competencia  | NomeBeneficiario |
	| 1         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "JOAO DA SILVA"  |
	| 1         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2019-01-01" | "MARIA DA SILVA" |
	| 2         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2018-12-01" | "JOAO DA SILVA"  |
	| 2         | "MSI - METRUS SAÚDE INTEGRAL" | "Mensalidade" | "2018-12-01" | "MARIA DA SILVA" |