using System;

namespace Trabalho3
{
    public class Especie : IPagamento
    {
        public decimal Valor {get; set;}
        public Especie(decimal valor)
        {
            Valor = valor;
        }
        public void ValidarDetalhesPagamento()
        {
            if(Valor == 0)
                System.Console.WriteLine("O valor deve ser maior que zero!");
        }
        public void ProcessarPagamento()
        {
            ValidarDetalhesPagamento();
            Console.WriteLine($"Processado pagamento em espécie de {Valor:C}.");
        }
    }
}