using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class ItemVenda
    {
        private int Quantidade {get; set;}
        private double Preco {get; set;} // Corrigir - derivado de Produto
        private List<Produto> vetProd {get; set;}
        private double Subtotal {get; set;}

        public ItemVenda(int quantidade, double preco){
            Quantidade = quantidade;
            Preco = preco;
            vetProd = new List<Produto>();
        }
        public double CalcularSubtotal(){
            
        }
    }
}