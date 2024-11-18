using Trabalho3;

internal class Program
{
    private static void Main(string[] args)
    {
        CartaoCredito c1 = new CartaoCredito("12345", 1000);
        c1.ProcessarPagamento();

        Paypal p1 = new Paypal("234", 0);
        p1.ProcessarPagamento();

        Especie e1 = new Especie(0);
        e1.ProcessarPagamento();
    }
}