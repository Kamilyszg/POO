// Método Main()

using ComposicaoBanco;

Banco banco= new Banco();
banco.AbrirConta();

ContaCorrente c1 = banco.contas[0];
c1.Depositar(1000);
c1.GerarExtratoConta();
System.Console.WriteLine("Após o saque");
c1.Sacar(200);
c1.GerarExtratoConta();

banco.AbrirConta();
ContaCorrente c2 = banco.contas[1];
c2.Depositar(1000);
c2.GerarExtratoConta();
System.Console.WriteLine("Após o saque");
c2.Sacar(2000);
c2.GerarExtratoConta();

banco.AbrirConta();
ContaCorrente c3 = banco.contas[2];
c3.Depositar(100);
c3.GerarExtratoConta();
System.Console.WriteLine("Após o saque");
c3.Sacar(2000);
c3.GerarExtratoConta();

banco.AbrirPoupanca();
Poupanca p1 = banco.poups[0];
p1.Depositar(1000);
p1.GerarExtratoPoups();
System.Console.WriteLine("Após o saque");
p1.Sacar(150);
p1.GerarExtratoPoups();
p1.GerarRendimento();
System.Console.WriteLine("Após a aplicação do rendimento");
p1.GerarExtratoPoups();

banco.VerificarFalencia();