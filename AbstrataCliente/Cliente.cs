using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        protected int codigo;
        protected string nome;
        protected private int idade;
    
        public int Codigo{
            get {return codigo;}
            set {codigo = value;}
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public virtual void MostrarAtributos(){
            System.Console.WriteLine("Código: "+ Codigo +"\tNome: "+ Nome +"\tIdade: " +Idade);
        }

        //assinatura de método definir retorno ou não; nome com significado; com parâmetro ou não;
        //método (membro) abstrato - torna-se o uso obrigatório em suas subclasses, mas não define lógica
        public abstract void VerificaIdade(); 
    }
}