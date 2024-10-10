using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataProduto
{
    public class Livro: Produto
    {
        public string Autor {get; set;}
        public string Isbn {get; set;}
        public Disco(int codigo, double preco, string autor, string isbn) : base(codigo, preco)
        {
            Autor = autor;
            Isbn = isbn;
        }

        public override void AtualizarPreco(double valor)
        {
            Preco = Preco + valor;
        }
    }
}