using System;

namespace Trabalho1
{    
    public class PagamentoEspecie : Pagamento
    {
        public double Quantia { get; set; } 
        public double Troco { get; private set; }

        public PagamentoEspecie(string data, double total, double quantia)
            : base(data, total)
        {
            Quantia = quantia;
        }

        public override bool RealizarPagamento()
        {
            if (Quantia >= Total)
            {
                Troco = Quantia - Total;
                Console.WriteLine($"Pagamento realizado com sucesso! Troco: {Troco:C}");
                return true;
            }
            else
            {
                Console.WriteLine("Quantia insuficiente. Pagamento cancelado.");
                return false;
            }
        }
    }
}