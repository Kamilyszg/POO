//Método Main()
using ArrayFuncionario;

//Criar um vetor de 3 elementos
//Cadastrar/digitar

//Calcule o total de salarios de todos os funcionarios
//Pesquise se há algum funcionario com 100 de salario
//Informe se encontrou.

Funcionario[] vetFuncionarios = new Funcionario[3];
double soma = 0;
for (int i = 0; i < vetFuncionarios.Length; i++)
{
    vetFuncionarios[i] = new Funcionario(); 
    System.Console.Write("Informe o código do funcionário: ");
    vetFuncionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Informe o nome do funcionário: ");
    vetFuncionarios[i].nome = Console.ReadLine();
    System.Console.Write("Informe o salário do funcionário: ");
    vetFuncionarios[i].salario = Convert.ToDouble(Console.ReadLine());
    soma += vetFuncionarios[i].salario;
}

foreach (Funcionario f in vetFuncionarios)
{
    f.MostrarAtributos();
}
System.Console.WriteLine($"Soma dos salários dos funcionários: {soma:c}\n");

int qtd = 0;
foreach (Funcionario f in vetFuncionarios)
{
    if (f.salario == 100)
    {
        System.Console.WriteLine("O funcionário: "+ f.nome +" possui um salário de R$100,00.");
        qtd += 1;
    }
}

if (qtd == 0)
    {
        System.Console.WriteLine("Não foram encontrados funcionários que possuam um salário de R$100,00.");
    }

System.Console.WriteLine("Quantidade de funcionários com salário igual a $100,00: "+ qtd);

/*Solução em sala

bool encontrado = false;
foreach(Funcionario f in vetFuncionarios)
{
    if(f.salario == 100)
        encontrado = true;
}

if (encontrado) // (encontrado == true)
    System.Console.WriteLine("Funcionário encontrado!");
else
    System.Console.WriteLine("Funcionário não encontrado!");
*/