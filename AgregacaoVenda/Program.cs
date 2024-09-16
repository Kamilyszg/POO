//Método Main();

using AgregacaoVenda;


Comprador cli1 = new Comprador(1000.00);
Comprador cli2 = new Comprador(100.00);

Vendedor vendedor1 = new Vendedor();

Produto p1 = new Produto("Produto A", 150.00);
Produto p2 = new Produto("Produto B", 250.00);
Produto p3 = new Produto("Produto C", 100.00);



Venda v1 = new Venda(cli1, vendedor1);

v1.AdicionarProduto(p1);
v1.AdicionarProduto(p2);
v1.AdicionarProduto(p3);

v1.RealizarVenda();

v1.MostrarAtributos();
cli1.MostrarAtributos();
vendedor1.MostrarAtributos();

Venda v2 = new Venda(cli2, vendedor1); //corrigir
v2.AdicionarProduto(p2);
v2.RealizarVenda();

v2.MostrarAtributos();
cli2.MostrarAtributos();
vendedor1.MostrarAtributos();