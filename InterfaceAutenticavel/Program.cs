using InterfaceAutenticavel;

// IAutenticavel ia = new IAutenticavel(); erro de compilação

Cliente c = new Cliente();
c.Senha = 123;
// System.Console.WriteLine(c.Autentica(123)); 

IAutenticavel ia = c; //Interface representa o objeto por isso recebe
Console.WriteLine(ia.Autentica(124)); // apenas serão mostrados os métodos que a interface e a classe compartilham entre si

Gerente g = new Gerente();
g.Senha = 100;

ia = g;
System.Console.WriteLine(ia.Autentica(100));

Diretor d = new Diretor();
d.Senha = 200;

ia = d;
System.Console.WriteLine(ia.Autentica(200));