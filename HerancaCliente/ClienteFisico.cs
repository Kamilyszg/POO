using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente //Classe derivada : Classe base
    {
        private int cpf;
        private int rg;
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public ClienteFisico(int codigo, string nome, int cpf, int rg) : base(codigo,nome)
        //manter a mesma ordem dos atributos do construtor da classe base
        //base - nome dos atributos da cb - sempre utilizar
        {
            Cpf = cpf;
            Rg = rg;
        }
        public ClienteFisico() : base()
        {
            
        }
        /*public void Mostrar(){

        }*/
    }
}