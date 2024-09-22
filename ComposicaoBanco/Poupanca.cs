namespace ComposicaoBanco
{
    public class Poupanca{
        private double saldo;

        public double Saldo{
            get {return saldo;}
        }

        public Poupanca(){
            //ctor padrão - saldo= 0
        }

        public double Depositar(double valor){
            saldo += valor;
            return saldo;
        }
        public double Sacar(double valor){
            if (saldo > valor){
                saldo -=valor;
                return saldo;
            }
            else{
                System.Console.WriteLine("Saldo insuficiente.");
                return -1;
            }
        }
        public void GerarRendimento(){
            System.Console.WriteLine("Saldo: "+ saldo);
        }
    }
}