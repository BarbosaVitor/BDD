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
namespace RetencaoDeRencimentos.Cenario05
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Reter o valor de salário mínimo na pensão judicial em duas competências diferente" +
        "s")]
    public partial class ReterOValorDeSalarioMinimoNaPensaoJudicialEmDuasCompetenciasDiferentesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "cenario05.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Reter o valor de salário mínimo na pensão judicial em duas competências diferente" +
                    "s", "  EU, como responsável pelo pagamento da rede credenciada\r\n  QUERO poder realizar" +
                    " a retenção de rendimentos de prestadores\r\n  PARA atender a determinação judicia" +
                    "l de pensão alimentícia", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Prestador credenciado com valor de pensão alimentícial indexada ao salário mínimo" +
            "")]
        [NUnit.Framework.CategoryAttribute("FLUXO_PRINCIPAL")]
        public virtual void PrestadorCredenciadoComValorDePensaoAlimenticialIndexadaAoSalarioMinimo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Prestador credenciado com valor de pensão alimentícial indexada ao salário mínimo" +
                    "", new string[] {
                        "FLUXO_PRINCIPAL"});
#line 8
 this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("um prestador credenciado que deve pagar dois salários mínimos de pensão alimentíc" +
                    "ia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Competencia",
                        "ValorDoSalarioMinimo"});
            table1.AddRow(new string[] {
                        "01",
                        "01/2017",
                        "937,00"});
            table1.AddRow(new string[] {
                        "02",
                        "01/2018",
                        "954,00"});
            table1.AddRow(new string[] {
                        "03",
                        "01/2019",
                        "998,00"});
#line 10
 testRunner.And("for parametrizado na sua decisão judiial", ((string)(null)), table1, "E ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Competencia",
                        "ValorApresentado",
                        "ValorGlosado",
                        "ValorAPagar",
                        "DescontoDeINSS",
                        "DescontoDeIRRF",
                        "ValorLiquido"});
            table2.AddRow(new string[] {
                        "01",
                        "10/2018",
                        "3.250,00",
                        "750,00",
                        "2.500,00",
                        "204,85",
                        "273,73",
                        "2.021,42"});
            table2.AddRow(new string[] {
                        "02",
                        "02/2019",
                        "7.850,00",
                        "125,00",
                        "7.725,00",
                        "632,99",
                        "845,83",
                        "6.246,18"});
#line 15
 testRunner.When("for realizado o faturamento de um PEG", ((string)(null)), table2, "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RepasseDaPensaoAlimenticia",
                        "ValorLiquido"});
            table3.AddRow(new string[] {
                        "01",
                        "954,00",
                        "1.067,42"});
            table3.AddRow(new string[] {
                        "02",
                        "998,00",
                        "5.248,18"});
#line 19
 testRunner.Then("deverá ser gerado um repasse referente a pensão alimentícia para o credenciado", ((string)(null)), table3, "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

