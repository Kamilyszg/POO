using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void MostrarAtributos(){
            System.Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: "+ Salario);
        }

        public virtual double CalcularBonificacao(){
            return Salario * 10/100;
        }
        
    }
}