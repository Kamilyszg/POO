using System;

namespace Trabalho3
{
    public interface IPagamento
    {
        public void ValidarDetalhesPagamento();
        public void ProcessarPagamento();
    }
}