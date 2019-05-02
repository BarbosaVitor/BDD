using System;
using TechTalk.SpecFlow;

namespace ConsultaFaturasEmAberto
{
    [Binding]
    public class BeneficiarioCanceladoNoSistemaMasAtivoNaDataDeReferenciaSteps
    {
        [Given(@"um beneficiário titular que tenha uma fatura em aberto")]
        public void DadoUmBeneficiarioTitularQueTenhaUmaFaturaEmAberto()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"cancelado")]
        public void DadoCancelado()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"ativo na data de referência")]
        public void DadoAtivoNaDataDeReferencia(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for consultado o saldo no dia ""(.*)""")]
        public void QuandoForConsultadoOSaldoNoDia(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o serviço deve retornar")]
        public void EntaoOServicoDeveRetornar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a Fatura retorna")]
        public void EntaoAFaturaRetorna(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"os Modulos retornam")]
        public void EntaoOsModulosRetornam(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
