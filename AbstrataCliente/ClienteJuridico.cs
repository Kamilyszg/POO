using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico: Cliente
    {
        private int cnpj;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public ClienteJuridico(int codigo, string nome, int idade, int cnpj) : base(codigo,nome,idade)
        {
            Cnpj = cnpj;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine("CNPJ: "+ Cnpj);
        }
        public override void VerificaIdade(){
            if (Idade >= 46){
                System.Console.WriteLine("Cliente Jurídico");
            }
        }
    }
}