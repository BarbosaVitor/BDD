using System;
using TechTalk.SpecFlow;

namespace RetencaoDeRencimentos.Cenario02
{
    [Binding]
    public class Cenario02Steps
    {
        [Given(@"que existe um credenciado que deve pagar um valor de pensão alimentícia")]
        public void DadoQueExisteUmCredenciadoQueDevePagarUmValorDePensaoAlimenticia(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"for realizado o faturamento do primeiro PEG")]
        public void QuandoForRealizadoOFaturamentoDoPrimeiroPEG(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deverá repassar para o credenciado descontando o valor da pensão alimentícia")]
        public void EntaoDeveraRepassarParaOCredenciadoDescontandoOValorDaPensaoAlimenticia(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"ao realizar o faturamento do segundo PEG")]
        public void EntaoAoRealizarOFaturamentoDoSegundoPEG(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"não deverá ser gerado nenhum desconto referente a pensão alimentícia pois o valor mensal já foi descontado no primeiro faturamento")]
        public void EntaoNaoDeveraSerGeradoNenhumDescontoReferenteAPensaoAlimenticiaPoisOValorMensalJaFoiDescontadoNoPrimeiroFaturamento(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
