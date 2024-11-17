using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; private set; }
        public double Subtotal {get; set;}

        public ItemVenda(Produto produto, int quantidade){
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
            Subtotal = CalcularSubtotal();
        }

        public double CalcularSubtotal()
        {
            Subtotal = Quantidade * Preco;
            if (Quantidade >= 50)
                Subtotal *= 0.8;
            return Subtotal;
        }
    }
}