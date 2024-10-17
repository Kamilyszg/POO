//Método Main
using AbstrataFuncionario;

Assalariado a1 = new Assalariado(1, "Pedro", 1000);
Assalariado a2 = new Assalariado(2, "Karina", 1000);
Comissionado c1 = new Comissionado(3, "Marcio", 1000, 0.20);
Comissionado c2 = new Comissionado(4, "Christian", 1000, 0.30);

Departamento d1 = new Departamento(1, "DEV");
d1.VetF = new List<Funcionario>();

d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
System.Console.WriteLine($"Total {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(2, "Redes");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
System.Console.WriteLine($"Total {d2.CalcularFolha(30):c}");
d2.Demitir(a2.Codigo);
d2.Listar();