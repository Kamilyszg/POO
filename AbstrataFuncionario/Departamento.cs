using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF {get; set;}

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            VetF = new List<Funcionario>();
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"\n...............Funcionários: {Nome}...............");
            System.Console.WriteLine("Código: "+ Codigo +"\tDepartamento: "+Nome);
        }
        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Listar()
        {
            MostrarAtributos();
            foreach (Funcionario f in VetF)
            {
                f.MostrarAtributos();
            }
        }
        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                {
                    VetF.Remove(f);
                }
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void MostrarQtdeDependentesFuncionario()
        {
            foreach (var f in VetF)
            {
                if(f.QtdDependentes >=1)
                {
                    Console.WriteLine($"O funcionário {f.Nome} tem {f.CalcularTotalDependentes()} dependentes.");
                    f.ListarDependentes();
                }
            }
        }
    }
}