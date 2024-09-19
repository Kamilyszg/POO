// Método Main()

using HerancaProduto;

Produto p1 = new Produto(1, "Garrafa", 5);
p1.Mostrar();
Produto p2 = new Produto(2, "Caixa", 10);
p2.Mostrar();


Perecivel per1= new Perecivel(3, "Pão", 2.99, "19/09/2024", "18/09/2024", 1);
per1.Mostrar();
Perecivel per2= new Perecivel(4, "Carne", 39.99, "19/09/2024", "15/09/2024", 2);
per2.Mostrar();
