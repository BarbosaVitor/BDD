using System;
using TechTalk.SpecFlow;

namespace ConsultaFaturasEmAberto
{
    [Binding]
    public class BeneficiarioAtivoComUmaFaturaEmAbertoSteps
    {
        [Given(@"um beneficiário titular com apenas uma fatura em aberto")]
        public void DadoUmBeneficiarioTitularComApenasUmaFaturaEmAberto(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for consultado o saldo devedor")]
        public void QuandoForConsultadoOSaldoDevedor(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o serviço deverá retornar")]
        public void EntaoOServicoDeveraRetornar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a Fatura")]
        public void EntaoAFatura(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"os Modulos desta fatura")]
        public void EntaoOsModulosDestaFatura(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
