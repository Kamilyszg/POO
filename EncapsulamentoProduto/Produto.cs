using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//testar encapsulamento
namespace EncapsulamentoProduto
{
    public class Produto
    {
        //declaração dos atributos
        public string nome;
        public double preco;
        public int qtd_estoque;
        //declaração dos métodos
        public string Nome
        {
            get { return nome.ToUpper(); } //tratamento no retorno
            set { this.nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { this.preco = value; }
        }

        public int Qtd_estoque
        {
            get { return qtd_estoque; }
            set //tratamento no recebimento
            { 
                if(value > 0)
                    this.qtd_estoque = value;
                else
                    System.Console.WriteLine("Quantidade Inválida!");
            }
        }
        
        
        












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