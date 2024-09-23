// Main()
using PolimorfismoFuncionario;

Funcionario f1 = new Funcionario(1, "Ricardo", 1000);
f1.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {f1.CalcularBonificacao():c}");

Secretario s1 = new Secretario(2, "Lia", 1000);
s1.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {s1.CalcularBonificacao():c}");

Gerente g1 = new Gerente(3, "Teo", 1000);
g1.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {g1.CalcularBonificacao():c}");

Diretor d1 = new Diretor(4, "Marcos", 1000);
d1.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {d1.CalcularBonificacao():c}");