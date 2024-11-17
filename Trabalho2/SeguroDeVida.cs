using System;

namespace Trabalho2
{
    public class SeguroDeVida : ITributavel 
    {
        public double ValorSeguro {get; set;}

        public SeguroDeVida(double valorSeguro)
        {
            ValorSeguro = valorSeguro - CalculaTributos();
        }
        public double CalculaTributos()
        {
            return 75;
        }

        public void ApresentarResultado()
        {
            System.Console.WriteLine($"Após o desconto de R$75,00 referente à tributação, o valor atual do seguro é de {ValorSeguro:C}");
        }
    }
}