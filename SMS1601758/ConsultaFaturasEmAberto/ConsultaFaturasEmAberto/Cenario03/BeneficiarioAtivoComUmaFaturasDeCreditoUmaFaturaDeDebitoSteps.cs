using System;
using TechTalk.SpecFlow;

namespace ConsultaFaturasEmAberto
{
    [Binding]
    public class BeneficiarioAtivoComUmaFaturasDeCreditoUmaFaturaDeDebitoSteps
    {
        [Given(@"um beneficiário titular ativo com duas faturas")]
        public void DadoUmBeneficiarioTitularAtivoComDuasFaturas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"uma de crédito")]
        public void DadoUmaDeCredito()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"uma de débito")]
        public void DadoUmaDeDebito(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for consultado o saldo passando como parâmetros de entrada")]
        public void QuandoForConsultadoOSaldoPassandoComoParametrosDeEntrada(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deverá ser retornado")]
        public void EntaoDeveraSerRetornado(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"as Faturas")]
        public void EntaoAsFaturas(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"os Modulos")]
        public void EntaoOsModulos(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
