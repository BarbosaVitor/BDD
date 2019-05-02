using System;
using TechTalk.SpecFlow;

namespace ConsultaFaturasEmAberto
{
    [Binding]
    public class BeneficiarioAtivoComDuasFaturasDeCreditoSteps
    {
        [Given(@"um beneficiário titular ativo")]
        public void DadoUmBeneficiarioTitularAtivo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"duas faturas de crédito")]
        public void DadoDuasFaturasDeCredito(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for consultado o saldo devedor do beneficiário")]
        public void QuandoForConsultadoOSaldoDevedorDoBeneficiario(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o serviço deverá retornar como resposta")]
        public void EntaoOServicoDeveraRetornarComoResposta(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"as Faturas devem retornar")]
        public void EntaoAsFaturasDevemRetornar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"os Modulos devem retornar")]
        public void EntaoOsModulosDevemRetornar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
