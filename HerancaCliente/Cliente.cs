using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo; //modificador de acesso específico para herança - classes derivadas conseguem visualizar os atributos
        protected string nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Cliente()
        {
            //construtor padrão
        }

        public void Mostrar(){
            System.Console.WriteLine("Código: "+ Codigo +"\tNome: "+ Nome);
        }
    }
}