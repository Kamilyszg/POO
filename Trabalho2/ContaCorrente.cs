using System;

namespace Trabalho2
{
    public class ContaCorrente : ITributavel 
    {
        public double Saldo {get; set;}

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }

        public double AbaterTributo()
        {
            return Saldo -= CalculaTributos();
        }

        public void ApresentarResultado()
        {
            System.Console.WriteLine($"Após o desconto de 5% referente à tributação, o saldo atual é de {Saldo:C}");
        }
    }
}