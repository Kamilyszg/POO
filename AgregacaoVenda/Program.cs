//Método Main();

using AgregacaoVenda;


Comprador cli1 = new Comprador(1000.00);

Vendedor vendedor1 = new Vendedor();

Produto p1 = new Produto("Produto A", 150.00);
Produto p2 = new Produto("Produto B", 250.00);
Produto p3 = new Produto("Produto C", 100.00);

List<Produto> vetProd = new List<Produto>();

Venda v1 = new Venda(cli1, vendedor1, vetProd);

v1.AdicionarProduto(p1);
v1.AdicionarProduto(p2);
v1.AdicionarProduto(p3);

v1.RealizarVenda();

cli1.MostrarAtributos();
v1.MostrarAtributos();
vendedor1.MostrarAtributos();