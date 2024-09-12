using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens{ get; set; }
        public NotaFiscal(int numeroNf, string data)
        {
            NumeroNF = numeroNf;
            Data = data;
            //a composição acontece agora, pois os objetos nota fiscal e vetor de itens são instanciados juntos (em um único construtor = em um único ato).
            VetItens = new List<ItemNotaFiscal>();
        }

        ~NotaFiscal(){
            VetItens = null;
            System.Console.WriteLine("Destruir a nota fiscal");
        }

    }
}