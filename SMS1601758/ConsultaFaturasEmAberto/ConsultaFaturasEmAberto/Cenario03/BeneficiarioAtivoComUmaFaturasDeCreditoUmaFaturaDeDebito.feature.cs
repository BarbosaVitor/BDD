﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ConsultaFaturasEmAberto.Cenario03
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Beneficiário ativo com uma faturas de crédito uma fatura de débito")]
    public partial class BeneficiarioAtivoComUmaFaturasDeCreditoUmaFaturaDeDebitoFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BeneficiarioAtivoComUmaFaturasDeCreditoUmaFaturaDeDebito.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Beneficiário ativo com uma faturas de crédito uma fatura de débito", "EU como responsável pela análise de crédito para empréstimos\r\nQUERO saber o saldo" +
                    " devedor do titular \r\nPARA consultar de faturas em aberto", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Consultar o saldo devedor de um beneficiário com duas faturas em aberto.")]
        [NUnit.Framework.CategoryAttribute("FLUXO_ALTERNATIVO")]
        public virtual void ConsultarOSaldoDevedorDeUmBeneficiarioComDuasFaturasEmAberto_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consultar o saldo devedor de um beneficiário com duas faturas em aberto.", new string[] {
                        "FLUXO_ALTERNATIVO"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
testRunner.Given("um beneficiário titular ativo com duas faturas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 10
testRunner.And("uma de crédito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "MatriculaFuncional",
                        "Nome",
                        "Cpf",
                        "Modulos",
                        "Plano"});
            table1.AddRow(new string[] {
                        "1",
                        "00123456",
                        "\"JOAO DA SILVA\"",
                        "\"79956013013\"",
                        "\"1 - MSI - METRUS SAUDE INTEGRAL\"",
                        "\"1 – Metro\""});
#line 11
testRunner.And("uma de débito", ((string)(null)), table1, "E ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CodigoDoPlano",
                        "MatriculaFuncional",
                        "Cpf",
                        "DataReferencia"});
            table2.AddRow(new string[] {
                        "1",
                        "1",
                        "\"00123456\"",
                        "\"79956013013\"",
                        "\"2019-02-25\""});
#line 14
testRunner.When("for consultado o saldo passando como parâmetros de entrada", ((string)(null)), table2, "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "CodigoDoPlano",
                        "MatriculaFuncional",
                        "Nome",
                        "Saldo",
                        "Juros",
                        "Multa",
                        "Correcao",
                        "Total",
                        "Faturas"});
            table3.AddRow(new string[] {
                        "1",
                        "1",
                        "\"00123456\"",
                        "\"JOÃO DA SILVA\"",
                        "800",
                        "4.54",
                        "16.35",
                        "0.54",
                        "821.43",
                        "[]"});
#line 17
testRunner.Then("deverá ser retornado", ((string)(null)), table3, "Então ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "IdFaturas",
                        "NumeroFatura",
                        "Parcela",
                        "Vencimento",
                        "Saldo",
                        "Juros",
                        "Multa",
                        "Correcao",
                        "Total",
                        "Modulos"});
            table4.AddRow(new string[] {
                        "1",
                        "85697",
                        "25",
                        "\"2019-01-25\"",
                        "1000",
                        "5.44",
                        "20.1",
                        "0.65",
                        "1026.19",
                        "[1]"});
            table4.AddRow(new string[] {
                        "2",
                        "78594",
                        "03",
                        "\"2019-01-31\"",
                        "-200",
                        "-0.9",
                        "-3.75",
                        "-0.11",
                        "-204.76",
                        "[2]"});
#line 20
testRunner.And("as Faturas", ((string)(null)), table4, "E ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "IdModulos",
                        "DescricaoModulo",
                        "Tipo",
                        "Competencia",
                        "NomeBeneficiario"});
            table5.AddRow(new string[] {
                        "1",
                        "\"MSI - METRUS SAÚDE INTEGRAL\"",
                        "\"Mensalidade\"",
                        "\"2019-01-01\"",
                        "\"JOAO DA SILVA\""});
            table5.AddRow(new string[] {
                        "1",
                        "\"MSI - METRUS SAÚDE INTEGRAL\"",
                        "\"Mensalidade\"",
                        "\"2019-01-01\"",
                        "\"MARIA DA SILVA\""});
            table5.AddRow(new string[] {
                        "2",
                        "\"MSI - METRUS SAÚDE INTEGRAL\"",
                        "\"Mensalidade\"",
                        "\"2018-12-01\"",
                        "\"JOAO DA SILVA\""});
#line 24
testRunner.And("os Modulos", ((string)(null)), table5, "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

