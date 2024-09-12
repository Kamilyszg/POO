// Método Main()

using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(20);

NotaFiscal nf = new NotaFiscal(1, "data");

nf.VetItens.Add(it1);
nf.VetItens.Add(it2);
System.Console.WriteLine("oi");

//nf = null; - forçando a destruição da instância
//GC.Collect(); - forçando a chamada do coletor de lixo e consequentemente seu destrutor.
