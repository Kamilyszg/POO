using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class PagamentoCheque : Pagamento
    {
        public long Numero { get; set; }
        public int Situacao { get; private set; } // 1: Aceito, 0: Recusado
        public double Quantia { get; set; }
        public string DataDeposito { get; set; }

        public PagamentoCheque(string data, double total, double quantia, long numero)
            : base(data, total)
        {
            Quantia = quantia;
            Numero = numero;
            DataDeposito = data; 
        }

        public override bool RealizarPagamento()
        {
            if (Quantia >= Total)
            {
                Situacao = 1;
                Console.WriteLine($"Cheque aceito! Número do Cheque: {Numero}. Pagamento realizado com sucesso.");
                return true;
            }
            else
            {
                Situacao = 0;
                Console.WriteLine("Cheque recusado. Pagamento cancelado.");
                return false; 
            }
        }
    }
}