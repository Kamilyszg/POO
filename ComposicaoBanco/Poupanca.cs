namespace ComposicaoBanco
{
    public class Poupanca{
        private double saldo;
        private static int contador = 1;
        private int numeroPoups;
        private static double taxaRendimento = 0.05;
        public double Rendimento { get; private set; }

        public double Saldo{
            get {return saldo;}
            private set {saldo = value;}
        }
        public int NumeroPoups{
            get {return numeroPoups;}
            private set {numeroPoups = value;}
        }

        public Poupanca(){
            numeroPoups = contador ++;       
            saldo = 0; // Inicializa o saldo como 0
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
        public double GerarRendimento(){
            Rendimento = saldo * taxaRendimento;
            saldo += Rendimento;
            return saldo;
        }

        public void GerarExtratoPoups(){
            System.Console.WriteLine($"Saldo da poupança {numeroPoups} = {saldo:C} \tRendimento = {Rendimento}");
        }
    }
}