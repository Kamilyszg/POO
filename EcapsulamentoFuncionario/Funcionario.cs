using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declaracao dos atributos - private
        private int codigo;
        private string nome;
        private double salario;

        /*Métodos de encapsulamento get e set - formato PHP e Java
        public void setCodigo(int codigo) // "setAtributo" convenção
        {
            this.codigo = codigo; //this.atributo = parâmetro -> this faz referência ao objeto instancido na Main()
        }
        public int getCodigo()
        {
            return this.codigo;
        }*/

        //Método de encapsulamento formato C#
        public int Codigo{
            set{
                this.codigo = value; //value pode ter a entrada de qualquer valor e tipo
            }
            get{
                return codigo;
            }
        }

        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return nome;
            }
        }

        public double Salario{
            set{
                this.salario = value;
            }
            get{
                return salario;
            }
        }

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