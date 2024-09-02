using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //declaração dos atributos
         private int numero; 
         private string titular;
         private double saldo;
         public Conta()
         {
            //construtor padrão
         }
         public Conta(int numero) //Construtor não tem tipo (void, int)
         {
            this.numero = numero; //Não tem retorno
         }
         public Conta(int numero, string titular)
         {
            this.numero = numero;
            this.titular = titular;
         }
         public Conta(int numero, string titular, double saldo)
         {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
         }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo: {saldo:c}");
        }
    }
}