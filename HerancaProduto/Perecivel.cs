using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string dtValidade;
        private string dtFabricacao;
        private int lote;

        public string DtValidade
        {
            get {return dtValidade;}
            set {dtValidade = value;}
        }

        public string DtFabricacao
        {
            get {return dtFabricacao;}
            set {dtFabricacao = value;}
        }

        public int Lote 
        { 
            get {return lote;}
            set {lote = value;}
        }

        public Perecivel(int codigo, string nome, double preco, string dtValidade, string dtFabricacao, int lote) : base(codigo,nome,preco)
        {
            DtValidade = dtValidade;
            DtFabricacao = dtFabricacao;
            Lote = lote;
        }
        public Perecivel(): base()
        {
            //ctor padrão
        }
        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("Data de Validade: "+ DtValidade +"\tData de Fabricação: "+DtFabricacao + "\tLote: "+Lote);
        }
    }
}