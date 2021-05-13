using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Pessoas
{
    public class Competidor : Pessoa
    {
        //Atributos
        protected string Tipo = "competidor";

        //Construtor
        public Competidor(string nome, string cpf, string celular) 
            : base(nome, cpf, celular)
        {

        }

        //Métodos
        public override void ExibeInfo()
        {
            Console.WriteLine("Nome do " + Tipo + ": " + Nome);
            Console.WriteLine("CPF do " + Tipo + ": " + CPF);
            Console.WriteLine("E-mail do " + Tipo + ": " + Celular);
        }
    }
}
