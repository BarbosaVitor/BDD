using System;
using TechTalk.SpecFlow;

namespace ConsultaFaturasEmAberto
{
    [Binding]
    public class BeneficiarioCanceladoNoSistemaENaDataDeReferenciaSteps
    {
        [Given(@"um beneficiário titular com uma fatura em aberto")]
        public void DadoUmBeneficiarioTitularComUmaFaturaEmAberto()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"cancelado no sistema")]
        public void DadoCanceladoNoSistema()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"cancelado na data de referência")]
        public void DadoCanceladoNaDataDeReferencia(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for consultado o saldo devedor no dia ""(.*)""")]
        public void QuandoForConsultadoOSaldoDevedorNoDia(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o serviço retornará")]
        public void EntaoOServicoRetornara(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a Fatura deverá retornar")]
        public void EntaoAFaturaDeveraRetornar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"os Modulos da Fatura deverão retornar")]
        public void EntaoOsModulosDaFaturaDeveraoRetornar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
