using System;

namespace AgregacaoVenda
{
    class Comprador
    {
        public double verba;

        public Comprador(double verba)
        {
            this.verba = verba;
        }

        public bool SubtrairVerba(double valorVenda){
            if(valorVenda > verba){
                System.Console.WriteLine("O comprador não possui verba disponível para a compra do(s) produto(s).");
                return false;
            }
            else
            {
                verba -= valorVenda;
                return true;
            }
        }
        public void MostrarAtributos(){
            System.Console.WriteLine($"Verba disponível do comprador: {verba:C}");
        }
    }
}