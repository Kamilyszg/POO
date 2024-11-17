using System;

namespace Trabalho1
{
    public abstract class Pagamento
    {
        public string Data { get; set; } 
        public double Total { get; set; }

        public Pagamento(string data, double total)
        {
            Data = data;
            Total = total;
        }
        public abstract bool RealizarPagamento();
    }
}
