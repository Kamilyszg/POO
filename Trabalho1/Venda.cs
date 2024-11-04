using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class Venda
    {
        private string Data {get; set;}
        private List<ItemVenda> vetItens {get; set;}
        private Pagamento Pag {get; set;}
        private double Total {get; set;}

        public Venda(string data, double total){
            Data = data;
            vetItens = new List<ItemVenda>();
        }

        //criar método para reduzir o estoque - se a venda for efetuada então diminue
    }
}