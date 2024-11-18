using System;

namespace Trabalho4
{
    public class ValidadorUsuario
    {
        public Conta Conta { get; set; }

        public ValidadorUsuario(Conta conta)
        {
            Conta = conta;
        }

        // Responsabilidade de validação do usuário
        public bool ValidarUsuario(string nome)
        {
            if (Conta.Titular == nome)
            {
                System.Console.WriteLine("Usuário válido");
                return true;
            }
            else
            {
                System.Console.WriteLine("Usuário inválido");
                return false;
            }
        }
    }
}