using System;

namespace Trabalho4
{
    public class GeradorRelatorios
    {
        public Conta Conta {get; set;}

        public GeradorRelatorios(Conta conta)
        {
            Conta = conta;
        }

        // Responsabilidade de gerar relatórios
        public string GerarRelatorio()
        {
            return $"Titular: {Conta.Titular}\tSaldo: {Conta.Saldo:C}";
        }  
    }
}