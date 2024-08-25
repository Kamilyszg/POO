using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
{
    public class Conta
    {
        //declaração dos atributos
         public int numero; //ao colocar public irá aparecer como opção da classe em outro arquivo
         public string titular;
         public double saldo;

        //declaração dos métodos
        public void Sacar()
        {

        }

        public void Depositar()
        {

        }

        public string toString()
        {
            return "número da conta: " + numero + "\ttítular da conta: " + titular + "\tsaldo da conta: " + saldo; //método que substitui a apresentação
        }
    }
}