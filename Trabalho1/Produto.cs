using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class Produto
    {
        private long Codigo {get; set;}
        private string Nome {get; set;}
        private double Preco {get; set;}
        private int Estoque {get; set;}

        public Produto(long codigo, string nome, double preco, int estoque){
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;            
        }

        public void DiminuirEstoque(int quantidade){
            if (Estoque >= quantidade)
                Estoque -= quantidade;
            else
                System.Console.WriteLine("");

            System.Console.WriteLine($"O estoque de {Nome} disponível é: {Estoque} unidades");
        }
    }
}