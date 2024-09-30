namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> poups {get; private set;}
        public List<ContaCorrente> contas {get; private set;}

        public Banco()
        {
            poups = new List<Poupanca>();
            contas = new List<ContaCorrente>();
        }

        public void AbrirConta(){
            ContaCorrente novaConta = new ContaCorrente();
            contas.Add(novaConta);
            System.Console.WriteLine("Conta Corrente de número: " + novaConta.NumeroConta + " foi criada.");
        }
        public void AbrirPoupanca(){
            Poupanca novaPoupanca = new Poupanca();
            poups.Add(novaPoupanca);
            System.Console.WriteLine("Conta Poupança de número: " + novaPoupanca.NumeroPoups + " foi criada.");
        }

        public bool VerificarFalencia(){
            int qtdInadimplentes = 0;
            int qtdClientesPositivos = 0;
            
            foreach (var conta in contas)
                {
                    if (conta.Saldo < 0)
                    {
                        qtdInadimplentes++;
                    }
                    else
                    {
                        qtdClientesPositivos++;
                    }
                }
            if (qtdInadimplentes > qtdClientesPositivos)
            {
                System.Console.WriteLine("O banco foi declarado em falência!");
                poups = new List<Poupanca>();
                contas = new List<ContaCorrente>();
                return true;
            }
            else
            {
                System.Console.WriteLine("O banco está em situação estável.");
                return false;
            }
        }

        ~Banco(){
            if (VerificarFalencia()== true)
                contas = null;
                poups = null;
        }
    }
}