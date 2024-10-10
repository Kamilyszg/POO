using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataProduto
{
    public class Disco : Produto
    {
        public string Artista {get; set;}
        public string Gravadora {get; set;}
        public Disco(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public override void AtualizarPreco(double valor)
        {
            Preco = Preco + valor;
        }
    }
}