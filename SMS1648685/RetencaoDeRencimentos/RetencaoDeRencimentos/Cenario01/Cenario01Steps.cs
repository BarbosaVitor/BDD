using System;
using TechTalk.SpecFlow;

namespace RetencaoDeRencimentos.Cenario01
{
    [Binding]
    public class Cenario01Steps
    {
        [Given(@"um credenciado que deve pagar um valor mensal de pensão alimentícia")]
        public void DadoUmCredenciadoQueDevePagarUmValorMensalDePensaoAlimenticia(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for realizado o faturamento do pagamento de um PEG")]
        public void QuandoForRealizadoOFaturamentoDoPagamentoDeUmPEG(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deverá ser gerado o repasse referente a pensão alimentícia, gerando para o credenciado o valor líquido de R\$ (.*)\.(.*)\.")]
        public void EntaoDeveraSerGeradoORepasseReferenteAPensaoAlimenticiaGerandoParaOCredenciadoOValorLiquidoDeR_(int p0, Decimal p1, Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
