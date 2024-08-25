// Funcao main()

using ClasseFuncionario;// abre a comunicação entre arquivos

Funcionario f1 = new Funcionario();//1º- instânciar o objeto

System.Console.WriteLine("Digite o código: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite o nome: ");
f1.nome = Console.ReadLine();
System.Console.WriteLine("Digite o salário: ");
f1.salario = Convert.ToDouble(Console.ReadLine());

f1.MostrarAtributos(); //enviando uma mensagem

System.Console.WriteLine("Digite a porcentagem de aumento: ");
int porcentagem = Convert.ToInt32(Console.ReadLine());
f1.AumentarSalario(porcentagem);
f1.MostrarAtributos();

Funcionario f2 = new Funcionario();

System.Console.WriteLine("Digite o código: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite o nome: ");
f2.nome = Console.ReadLine();
System.Console.WriteLine("Digite o salário: ");
f2.salario = Convert.ToDouble(Console.ReadLine());
f2.MostrarAtributos();

System.Console.WriteLine("Digite a porcentagem de aumento: ");
porcentagem = Convert.ToInt32(Console.ReadLine());
f2.AumentarSalario(porcentagem);
f2.MostrarAtributos();

double somaSalarios = f1.salario + f2.salario;
