using System;
using TechTalk.SpecFlow;

namespace RetencaoDeRencimentos
{
    [Binding]
    public class Cenario04Steps
    {
        [Given(@"um prestador credenciado que deve pagar dois salários mínimos de pensão alimentícia")]
        public void DadoUmPrestadorCredenciadoQueDevePagarDoisSalariosMinimosDePensaoAlimenticia()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"for parametrizado na sua decisão judiial")]
        public void DadoForParametrizadoNaSuaDecisaoJudiial(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for realizado o faturamento de um PEG")]
        public void QuandoForRealizadoOFaturamentoDeUmPEG(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deverá ser gerado um repasse referente a pensão alimentícia para o credenciado")]
        public void EntaoDeveraSerGeradoUmRepasseReferenteAPensaoAlimenticiaParaOCredenciado(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
