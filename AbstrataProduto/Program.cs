//Método Main()
using AbstrataProduto;
//Produto p = new Produto();
Disco d = new Disco(1, 21, "Luiza Sonza", "UMusic");
d.AtualizarPreco(100);
System.Console.WriteLine(d.Preco);

Livro l = new Livro(2, 300, "Box Duna", "Editora");

l.AtualizarPreco(200);
System.Console.WriteLine(l.Preco);