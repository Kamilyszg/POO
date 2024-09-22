using System;

namespace AgregacaoVenda
{
    class Venda
    {
        public Comprador comp;

        public Vendedor vend;

        public List<Produto> vetProd;

        public Venda(Comprador comp, Vendedor vend)
        {
            this.comp = comp;
            this.vend = vend;
            vetProd = new List<Produto>();
        }
        public void AdicionarProduto(Produto prod)
        {
            vetProd.Add(prod);
        }

        private double CalcularValorVenda(){
            double total = 0;
            foreach(var produto in vetProd){
                total += produto.Preco;
            }
            return total;
        }

        public double CalcularComissao(double valorVenda){
            return valorVenda * 0.02;
        }

        public void RealizarVenda()
        {
            vend.comissao = 0; //reinicia a comissção do vendedor a cada nova venda
            double valorVenda = CalcularValorVenda(); 
            if (comp.SubtrairVerba(valorVenda)){ //se o cliente tem a verba neessária
                double comissao = CalcularComissao(valorVenda);
                vend.AdicionarComissao(comissao);
                System.Console.WriteLine("Venda realizada com sucesso.");
            }
            else{
                System.Console.WriteLine("Venda não realizada - verba insuficiente.");
            }
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Produtos na venda");
            foreach(var produto in vetProd)
            {
                produto.MostrarAtributos();
            }
            double valorVenda = CalcularValorVenda(); //usa o valor para apresentar
            System.Console.WriteLine($"Valor da venda: {valorVenda:C}");
        }
    }
}