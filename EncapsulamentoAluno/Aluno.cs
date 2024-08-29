using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    { //encapsulamento compacto (proriedade prop)
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; } //a média não pode ser atribuída por um usuário externo, deve ser calculada.

        //declaração dos métodos
        public void CalcularMedia()
        {
            Media = (P1 + P2) / 2; //set
        }
        //metodo mostrar
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Matrícula: {Matricula} \tNome: {Nome} \tP1: {P1} \tP2: {P2}\tMédia: {Media:n}");
        }
    }
}