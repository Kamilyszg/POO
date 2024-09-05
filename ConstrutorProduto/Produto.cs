using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Qtde { get; set; }

        // Criar 3 Construtores
        // Criar o método MostrarAtributos()
        public Produto(){
            //Construtor Padrão
        }
        public Produto(int Codigo){
            this.Codigo = Codigo;
        }
        public Produto(int Codigo, string Nome){
            this.Codigo = Codigo;
            this.Nome = Nome;
        }
        public void MostrarAtributos(){
            Console.WriteLine("Código: "+ Codigo +"\tNome: " + Nome + "\tPreço: " + Preco + "\tQuantidade: " + Qtde);
        }
    }
}