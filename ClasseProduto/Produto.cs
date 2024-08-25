using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração dos atributos
        public string nome;
        public double preco;
        public int qtd_estoque;
        //declaração dos métodos
        public void AdicionarProduto(int qtd)
        {
            qtd_estoque += qtd;
        }

        public void RemoverProduto(int qtd)
        {
            qtd_estoque -= qtd;
        }

        public double ValorTotalEstoque()
        {
            return preco * qtd_estoque;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Dados do Produto");
            System.Console.WriteLine("Nome: " + nome + "\tPreço: " + preco +"\tQuantidade em estoque: " + qtd_estoque);
        }

    }
}