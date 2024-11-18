using System;

namespace Trabalho3
{
    public class CartaoCredito : IPagamento
    {
        public string IdConta {get; set;}
        public decimal Valor {get; set;}

        public CartaoCredito(string idConta, decimal valor)
        {
            IdConta = idConta;
            Valor = valor;
        } 
        public void ValidarDetalhesPagamento()
        {
            if (string.IsNullOrWhiteSpace(IdConta))
                Console.WriteLine("ID da conta é requerido.");
            if (Valor <= 0)
                Console.WriteLine("O valor deve ser maior que zero!");
        }

        public void ProcessarPagamento()
        {
            ValidarDetalhesPagamento();
            Console.WriteLine($"Processado pagamento de{Valor:C} da conta: {IdConta}");
        }
    }
}