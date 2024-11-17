using Trabalho2;

ContaCorrente c1 = new ContaCorrente(1000);
SeguroDeVida s1 = new SeguroDeVida(1000);

c1.CalculaTributos();
s1.CalculaTributos();

TotalizadorDeTributos t = new TotalizadorDeTributos();
t.Adiciona(c1);
t.Adiciona(s1);
t.Apresenta();

c1.AbaterTributo();
c1.ApresentarResultado();
s1.ApresentarResultado();


