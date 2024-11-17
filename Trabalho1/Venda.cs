using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class Venda
    {
    public string Data { get; set; }
        public List<ItemVenda> vetItens { get; set; }
        public double Total { get; private set; }
        public Pagamento Pag { get; set; }

        public Venda(string data){
            vetItens = new List<ItemVenda>();
            Data = data;
        }

        public void AdicionarItem(ItemVenda item){
            Total += item.Subtotal;
            vetItens.Add(item);
        }

        public bool RealizarVenda()
        {
            foreach (ItemVenda item in vetItens)
            {
                if (item.Quantidade > item.Produto.Estoque)
                {
                    Console.WriteLine($"Estoque insuficiente para o produto {item.Produto.Nome}. Venda cancelada.");
                    return false;
                }
            }

            if (Pag.RealizarPagamento())
            {
                foreach (ItemVenda item in vetItens)
                {
                    item.Produto.AtualizarEstoque(item.Quantidade);
                }

                Console.WriteLine($"Venda realizada com sucesso! Total da venda: {Total:C}");
                return true;
            }

            return false;
        }
    }
}