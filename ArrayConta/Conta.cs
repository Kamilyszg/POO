using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        //declaração dos atributos
         public int numero; 
         public string titular;
         public double saldo;

        //declaração dos métodos
        public void Sacar()
        {

        }

        public void Depositar()
        {

        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo: {saldo:c}");
        }
    }
}