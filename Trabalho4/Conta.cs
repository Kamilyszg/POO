using System;

namespace Trabalho4
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
        } 

        // Responsabilidade de gerenciar saldo
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser positivo!");
            }
            Saldo += valor;
            System.Console.WriteLine($"O saldo atual é de: {Saldo:C}");
        }

        // Responsabilidade de gerenciar saldo
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else{
            Saldo -= valor;
            System.Console.WriteLine($"O saldo atual é de: {Saldo:C}");}
        }    
    }
}