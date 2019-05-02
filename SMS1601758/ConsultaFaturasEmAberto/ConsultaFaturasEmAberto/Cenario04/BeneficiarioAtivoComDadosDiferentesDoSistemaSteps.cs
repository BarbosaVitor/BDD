using System;
using TechTalk.SpecFlow;

namespace ConsultaFaturasEmAberto
{
    [Binding]
    public class BeneficiarioAtivoComDadosDiferentesDoSistemaSteps
    {
        [Given(@"um beneficiário titular")]
        public void DadoUmBeneficiarioTitular()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"uma fatura em aberto")]
        public void DadoUmaFaturaEmAberto(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for consultado")]
        public void QuandoForConsultado(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o serviço deverá retornar uma mensagem de erro")]
        public void EntaoOServicoDeveraRetornarUmaMensagemDeErro()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
