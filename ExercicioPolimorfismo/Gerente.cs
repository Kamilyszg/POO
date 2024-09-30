using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo
{
    public class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario) : base(codigo, nome, salario){

        }

        public override double CalcularBonificacao(){
            //lógica que vai substituir/sobrescrever o método da super-classe
            return Salario * 15/100;
        }
    }
}