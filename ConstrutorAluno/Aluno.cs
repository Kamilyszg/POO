using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private long matricula = 1570482313000;
        private string nome;
        private static int aux;

        public static int Aux{
            get{
                return aux;
            }
        }

        public Aluno(){
            aux ++;
        }

        public Aluno(string nome){
            this.nome = nome;
            aux ++;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("Matricula: "+(matricula+aux)+"\tNome: "+nome);
        }
    }
}