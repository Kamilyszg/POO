//Método Main()

using AgregacaoConta;

Cliente cli1 = new Cliente("Ana", 1234);

Conta c1 = new Conta(1,100);

c1.Titular = cli1; // a partir do momento em que o atributo "titular" da classe conta recebe um objeto da classe Cliente, este também torna-se um objeto. - Agregação acontece agora.
Console.WriteLine("Número: " + c1.Numero +"\tTitular - Nome: " + c1.Titular.Nome + "\tTitular - Rg: " + c1.Titular.Rg + "\tSaldo: " + c1.Saldo);


Conta c2 = new Conta(2,200);
c2.Titular = new Cliente(); //construtor padrão
c2.Titular.Nome = "Bia";
c2.Titular.Rg = 2000;

Console.WriteLine("Número: " + c2.Numero +"\tTitular - Nome: " + c2.Titular.Nome + "\tTitular - Rg: " + c2.Titular.Rg + "\tSaldo: " + c2.Saldo);