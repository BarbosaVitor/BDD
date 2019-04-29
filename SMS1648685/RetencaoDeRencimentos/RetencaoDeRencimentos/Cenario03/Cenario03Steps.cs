using System;
using TechTalk.SpecFlow;

namespace RetencaoDeRencimentos.Cenario03
{
    [Binding]
    public class Cenario03Steps
    {
        [Given(@"um prestador credenciado que deve pagar pensão alimentícia")]
        public void DadoUmPrestadorCredenciadoQueDevePagarPensaoAlimenticia(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"um PEG for faturado")]
        public void QuandoUmPEGForFaturado(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"restará ainda um valor para quitação")]
        public void EntaoRestaraAindaUmValorParaQuitacao(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"quando for realizado o faturamento de um segundo PEG")]
        public void EntaoQuandoForRealizadoOFaturamentoDeUmSegundoPEG(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deverá gerar um desconto referente a pensão alimentícia ainda não quitado no mês")]
        public void EntaoDeveraGerarUmDescontoReferenteAPensaoAlimenticiaAindaNaoQuitadoNoMes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"um valor líquido de pagamento")]
        public void EntaoUmValorLiquidoDePagamento(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
