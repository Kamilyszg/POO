//Método Main()
using EncapsulamentoFuncionario;

/*Encapsulamento mais detalhado e parecido com PHP e Java
Funcionario f1 = new Funcionario();
f1.setCodigo(1); //insere
System.Console.WriteLine("Código: "+f1.getCodigo());

Funcionario f2 = new Funcionario();
f2.setCodigo(2);
System.Console.WriteLine("Código: " + f2.getCodigo());*/

//Formato C#
Funcionario f1= new Funcionario();
f1.Codigo = 1; //aqui é executado o método set pois é o unico que recebe um valor "="
System.Console.WriteLine("Código: " + f1.Codigo); //aqui chama o método get 
f1.Nome = "Kamily";
System.Console.WriteLine("Nome: " + f1.Nome);
f1.Salario = 3000;
System.Console.WriteLine("Salário: " + f1.Salario);