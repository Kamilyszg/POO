using System;

namespace Trabalho1
{
    public class PagamentoCartao : Pagamento
    {
        public string DadosDaTransacao{get; set;}
        public int ResultadoDaTrasacao{get; set;}

        public PagamentoCartao(string data, double total, string dados) : base(data, total)
        {
            DadosDaTransacao = dados;
        }

        public override bool RealizarPagamento()
        {
            if(DadosDaTransacao != null)
            {
                ResultadoDaTrasacao = 1;
                Console.WriteLine("Pagamento realizado.");
                return true;
            }
            Console.WriteLine("Pagamento não realizado.");
            return false;
        }
    }
}