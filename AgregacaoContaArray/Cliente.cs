using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaArray
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Rg { get; set; }

        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }

        public Cliente()
        {
            //construtor padrão
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Nome: " + Nome + "\tRg: " + Rg);
        }
    }
}