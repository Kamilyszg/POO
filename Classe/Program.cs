// função Main()
using Classe;

//intanciar objetos
Conta c1; //declaração de uma variável
c1 = new Conta();  //instância de um objeto do new pra frente
c1.numero = 1;
c1.titular = "Fatec";
c1.saldo = 100;
Console.WriteLine("Número: "+ c1.numero +"\tTítular: "+ c1.titular +"\tSaldo: " + c1.saldo);

Conta c2 = new Conta();
//Conta (tipo de classe), c2 (objeto), new (alocação de memória), Conta() (construtor da classe)
c2.numero = 2;
c2.titular = "Empresa Jr";
c2.saldo = 200;
Console.WriteLine("Número: "+ c2.numero +"\tTítular: "+ c2.titular +"\tSaldo: " + c2.saldo);

Conta c3 = new Conta();
Console.Write("Cadastre o número da conta: ");
c3.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Cadastre o títular da conta: ");
c3.titular = Console.ReadLine();
Console.Write("Cadastre o saldo da conta: ");
c3.saldo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(c3.toString()); //método declarado no arquivo Conta