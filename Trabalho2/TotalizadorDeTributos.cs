using System;

namespace Trabalho2
{
    public class TotalizadorDeTributos 
    {
        public double Total {get; set;}

        public void Adiciona(ITributavel t)
        {
            Total += t.CalculaTributos();
        }

        public void Apresenta()
        {
            System.Console.WriteLine($"Total de tributos acumulados: {Total:C}");
        }

    }
}