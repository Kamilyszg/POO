using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;
        protected int qtdDependentes;
        protected List<Dependente> vetD;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int QtdDependentes
        {
            get {return qtdDependentes;}
            set {qtdDependentes = value;}
        }
        public List<Dependente> VetD
        {
            get { return vetD; }
            set { vetD = value; } // Tornar o setter privado
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public abstract double CalcularSalario (int diasUteis);

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }

        public int CalcularTotalDependentes()
        {
            return QtdDependentes;
        }

        public void AdicionarDependentes(Dependente novoDep)
        {
            VetD.Add(novoDep);
            QtdDependentes++;      
        }

        public void RemoverDependentesMaiorIdade(int codigo)
        {
            for (int i = vetD.Count - 1; i >= 0; i--)
            {
                if (VetD[i].VerificarMaiorIdade(VetD[i].Idade))
                {
                    VetD.RemoveAt(i);
                    QtdDependentes--;
                }
            }
        }

        public void ListarDependentes()
        {
            foreach (var d in vetD)
            {
                d.MostrarAtributosDependentes();
            }
        }
    }
}