using Trabalho4;

class Program
{
    static void Main(string[] args)
    {
        // Criando contas
        Conta c1 = new Conta("Kamily");
        c1.Deposito(500);
        c1.Sacar(200);

        Conta c2 = new Conta("Rafael");
        c2.Deposito(0);
        c2.Sacar(100);

        GeradorRelatorios g1 = new GeradorRelatorios(c1);
        Console.WriteLine(g1.GerarRelatorio());

        GeradorRelatorios g2 = new GeradorRelatorios(c2);
        Console.WriteLine(g2.GerarRelatorio());

        ValidadorUsuario v1 = new ValidadorUsuario(c1); 
        v1.ValidarUsuario("Kamily");

        ValidadorUsuario v2 = new ValidadorUsuario(c2); 
        v2.ValidarUsuario("João"); 
    }
}
