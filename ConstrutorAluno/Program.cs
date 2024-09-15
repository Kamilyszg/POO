using ConstrutorAluno;

internal class Program
{
    private static void Main(string[] args)
    {
        //Criar a classe Aluno, com os atributos
        //matricula, nome
        /*Utilizar os atributos static para criar as matrículas de forma automática a cada instância seguindo o padrão Fatec 1570482313000
        O atributo matricula não será static - A instância de cada objeto é única, o static será utilizado como auxiliar na criação automática
        Utilize se quiser o atributo contador para auxiliar a contagem e registro da matricula
        Criar o método mostrar e chamar após cada instância
        Instancie pelo menos 2 objetos de construtores diferentes (a maricula é para ser gerada)
        Entregar no Teams o arquivo Aluno.cs e Program.cs até dia 18/09
        */

        Aluno a1 = new Aluno();
        a1.MostrarAtributos();

        Aluno a2 = new Aluno("Matheus");
        a2.MostrarAtributos();

        Aluno a3 = new Aluno("Ana");
        a3.MostrarAtributos();
    }
}