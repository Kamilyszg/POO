// Método Main()

using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Ana";
c.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Cpf = 1111;
cf.Rg = 11;
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico(4, "Lia", 4444, 44);
cf2.Mostrar();