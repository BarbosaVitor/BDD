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
namespace RetencaoDeRencimentos.Cenario02
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Realizar o repasse de um valor parametrizado para um credenciado com dois pagamen" +
        "tos no mês, sendo que o primeiro pagamento já reteve o valor necessário")]
    public partial class RealizarORepasseDeUmValorParametrizadoParaUmCredenciadoComDoisPagamentosNoMesSendoQueOPrimeiroPagamentoJaReteveOValorNecessarioFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "cenario02.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Realizar o repasse de um valor parametrizado para um credenciado com dois pagamen" +
                    "tos no mês, sendo que o primeiro pagamento já reteve o valor necessário", "  EU, como responsável pelo pagamento da rede credenciada\r\n  QUERO poder realizar" +
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
        [NUnit.Framework.DescriptionAttribute("Credenciado com dois pagamentos na competência onde o primeiro atinge o valor tot" +
            "al do benefício")]
        [NUnit.Framework.CategoryAttribute("FLUXO_PRINCIPAL")]
        public virtual void CredenciadoComDoisPagamentosNaCompetenciaOndeOPrimeiroAtingeOValorTotalDoBeneficio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Credenciado com dois pagamentos na competência onde o primeiro atinge o valor tot" +
                    "al do benefício", new string[] {
                        "FLUXO_PRINCIPAL"});
#line 8
    this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RepasseDaPensaoAlimenticia"});
            table1.AddRow(new string[] {
                        "01",
                        "1.800,00"});
#line 9
    testRunner.Given("que existe um credenciado que deve pagar um valor de pensão alimentícia", ((string)(null)), table1, "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ValorApresentado",
                        "ValorGlosado",
                        "ValorAPagar",
                        "DescontoDeINSS",
                        "DescontoDeIRRF",
                        "ValorLiquido"});
            table2.AddRow(new string[] {
                        "01",
                        "7.000,00",
                        "200,00",
                        "6.800,00",
                        "621,04",
                        "829,86",
                        "5.349,10"});
#line 12
    testRunner.When("for realizado o faturamento do primeiro PEG", ((string)(null)), table2, "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RepasseDaPensaoAlimenticia",
                        "ValorLiquido"});
            table3.AddRow(new string[] {
                        "01",
                        "1.800,00",
                        "3.549,10"});
#line 15
    testRunner.Then("deverá repassar para o credenciado descontando o valor da pensão alimentícia", ((string)(null)), table3, "Então ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ValorApresentado",
                        "ValorGlosado",
                        "ValorAPagar",
                        "DescontoDeINSS",
                        "DescontoDeIRRF",
                        "ValorLiquido"});
            table4.AddRow(new string[] {
                        "01",
                        "3.500,00",
                        "500,00",
                        "3.000,00",
                        "245,82",
                        "328,48",
                        "2.425,70"});
#line 18
    testRunner.And("ao realizar o faturamento do segundo PEG", ((string)(null)), table4, "E ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "RepasseDaPensaoAlimenticia",
                        "ValorLiquido"});
            table5.AddRow(new string[] {
                        "01",
                        "0,00",
                        "2.425,70"});
#line 21
    testRunner.And("não deverá ser gerado nenhum desconto referente a pensão alimentícia pois o valor" +
                    " mensal já foi descontado no primeiro faturamento", ((string)(null)), table5, "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

