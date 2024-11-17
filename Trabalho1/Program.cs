using Trabalho1;

Produto p1 = new Produto(1, "mouse", 85.00, 100);
Produto p2 = new Produto(1, "headset", 100.00, 60);
Produto p3 = new Produto(1, "teclado", 60.00, 50);

ItemVenda i1 = new ItemVenda(p1, 80);
ItemVenda i2 = new ItemVenda(p2, 10);
ItemVenda i3 = new ItemVenda(p3, 10);

Venda venda = new Venda("01-05-2024");

venda.AdicionarItem(i1);
venda.AdicionarItem(i2);
venda.AdicionarItem(i3);

Console.WriteLine($"Total da venda: {venda.Total:C}");

Console.WriteLine("1.Espécie");
Console.WriteLine("2.Cartão");
Console.WriteLine("3.Cheque");
Console.Write("Digite a forma de pagamento: ");

int opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    PagamentoEspecie pagE = new PagamentoEspecie("17/11/2024", venda.Total, 10000.00);
    pagE.RealizarPagamento();
}
else if (opcao == 2)
{
    PagamentoCartao pagC = new PagamentoCartao("17/11/2024", venda.Total, "1235");
    pagC.RealizarPagamento(); 
}
else if (opcao == 3)
{
    PagamentoCheque pagCh = new PagamentoCheque("17/11/2024", venda.Total, 1000.00, 12);
    pagCh.RealizarPagamento();
}