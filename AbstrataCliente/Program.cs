// Método Main()

using AbstrataCliente;

//Cliente c = new Cliente(1,"Ana"); - gera erro por não poder instanciar (objeto abstrato)

ClienteFisico cf = new ClienteFisico(2,"Bia", 20, 222);
cf.MostrarAtributos();

Teste t = new Teste();
t.AvaliarIdade(cf);

ClienteJuridico cj = new ClienteJuridico(3, "João", 48, 33333);
cj.MostrarAtributos();

Teste t2 = new Teste();
t2.AvaliarIdade(cj);