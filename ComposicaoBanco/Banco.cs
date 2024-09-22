namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> poups {get; set;}
        public List<ContaCorrente> contas {get; set;}

        public Banco()
        {
            poups = new List<Poupanca>();
            contas = new List<ContaCorrente>();
        }

        public void IniciarBanco(){
            //método que permite resetar todas as contas manualmente
            poups = new List<Poupanca>();
            contas = new List<ContaCorrente>();
        }
        public void AbrirConta(){
            ContaCorrente novaConta = new ContaCorrente();
            contas.Add(novaConta);
            System.Console.WriteLine("Conta Corrente de número: " + novaConta.NumeroConta + " foi criada.");
        }
        public void AbrirPoupanca(){
            Poupanca p1 = new Poupanca();
            poups.Add(p1);
        }
        public void DecretarFalencia(){

        }
    }
}