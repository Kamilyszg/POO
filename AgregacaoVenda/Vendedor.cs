using System;

namespace AgregacaoVenda
{
    class Vendedor
    {
        public double comissao { get; set; }

        public Vendedor()
        {
            //construtor padrão: comissão - 0.00
        }
        public void AdicionarComissao(double valorVenda)
        {
            this.comissao += valorVenda;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Comissão do vendedor: {comissao:C}");
        }
    }
}