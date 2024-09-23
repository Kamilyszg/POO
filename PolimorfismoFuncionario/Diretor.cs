using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario) : base(codigo, nome, salario){
            
        }

        public override double CalcularBonificacao(){ 
            //lógica que vai complementar o método da super-classe : 10% + 1000
            return base.CalcularBonificacao() + 1000;
        }
    }
}