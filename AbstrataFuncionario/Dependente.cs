using System;

namespace AbstrataFuncionario;

public class Dependente
{
    private int codigo;
    private string nome;
    private int idade;

    public int Codigo{
        get {return codigo;}
        set {codigo = value;}
    }

    public string Nome{
        get {return nome;}
        set {nome = value;}
    }

    public int Idade{
        get {return idade;}
        set {idade = value;}
    }

    public Dependente(int codigo, string nome, int idade)
    {
        Codigo = codigo;
        Nome = nome;
        Idade = idade;
    }

    public bool VerificarMaiorIdade(int idade)
    {
        int maiores = 0;
        if (idade >= 18)
        {
            maiores += 1;
            return true;
        }
        else
            return false;
    }

    public void MostrarAtributosDependentes()
    {
        Console.WriteLine("ID Dependente: "+ Codigo+ "\tNome: "+ Nome + "\tIdade: " + Idade);
    }
}