using System;

namespace AgregacaoVenda
{
    class Produto
    {
        private static int auxCodigo = 500;
        private int codigo;
        private string nome;
        private double preco;

        public int Codigo
        {
            get { return codigo; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get{ return preco; }
            set{ preco = value; }
        }

        public Produto(string nome, double preco){
            this.codigo = auxCodigo++;
            this.nome = nome;
            this.preco = preco;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {codigo}\tNome: {nome}\tpreco: {preco:C}");
        }
    }
}