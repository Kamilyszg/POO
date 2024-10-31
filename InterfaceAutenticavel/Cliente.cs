using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{ //classe cliente IMPLEMENTA a interface IAutenticavel
    public class Cliente: IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Cliente autenticado");
                return true;
            }
            return false;
        }
    }
}