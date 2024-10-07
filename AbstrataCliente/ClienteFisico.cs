using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public ClienteFisico(int codigo, string nome, int idade, int rg) : base(codigo,nome,idade)
        {
            Rg = rg;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine("Rg: "+Rg);
        }
        public override void VerificaIdade(){
            if (Idade >= 18 && Idade <= 45){
                System.Console.WriteLine("Cliente Físico");
            }
        }
    }
}