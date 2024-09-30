namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        private double chequeEspecial;
        private static int contador= 1;
        private int numeroConta;

        public double Saldo{
            get {return saldo;}
            private set {saldo = value;}
        }
        public double ChequeEspecial{
            get {return chequeEspecial;}
            private set {chequeEspecial = value;}
        }

        public int NumeroConta{
            get {return numeroConta;}
            private set {numeroConta = value;}
        }

        public ContaCorrente(){
            //construtor padrão - a cada nova conta corrente definem-se as configurações abaixo
            numeroConta = contador++;
            saldo = 0;
            chequeEspecial = 300;
        }

        public double Depositar(double valor){
            saldo += valor;
            return saldo;
        }
        public double Sacar(double valor){ //se o cliente sacar mais do que pode a diferenca deve ir para o cheque especial
            if (valor <= saldo){
                saldo -= valor;
                return saldo;
            }
            else{
                chequeEspecial -= valor - saldo;
                saldo = 0;
                return chequeEspecial;
            }
        }
        public void GerarExtratoConta(){
            System.Console.WriteLine("Saldo: "+ saldo+ "\tCheque Especial: "+ chequeEspecial);
        }
    }
}