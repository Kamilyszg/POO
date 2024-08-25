using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        //declaracao dos atributos
        public int codigo;
        public string nome;
        public double salario;
        public void MostrarAtributos() //metodo começa com letra maiuscula- PascalCase
        {
            Console.WriteLine("Código: "+ codigo + "\tNome: " + nome + "\tSalário: " + salario);
        }
        //Criar um metodo para aplicar uma porcentagem de aumento de salario
        public void AumentarSalario(int porcentagem)
        {
            salario = salario + (salario * porcentagem/100);
            System.Console.WriteLine("Salario após o aumento de "+ porcentagem +"% se estabelece em: " + salario);
        }
    }
}