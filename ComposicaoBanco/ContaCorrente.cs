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
        }
        public double ChequeEspecial{
            get {return chequeEspecial;}
        }

        public int NumeroConta{
            get {return numeroConta;}
            set {numeroConta = value;}
        }

        public ContaCorrente(){
            //construtor padrão - a cada nova conta corrente definem-se as configurações abaixo
            numeroConta = contador++;
            saldo = 0;
            chequeEspecial = 100;
        }

        public double Depositar(double valor){
            saldo += valor;
            return saldo;
        }
        public double Sacar(double valor){
            if (valor <= saldo + chequeEspecial){
                saldo -= valor;
                return saldo;
            }
            else{
                System.Console.WriteLine("Saldo insuficiente.");
                return -1;
            }
        }
        public void GerarExtrato(){
            System.Console.WriteLine("Saldo: "+ saldo+ "Cheque Especial: "+ chequeEspecial);
        }
    }
}