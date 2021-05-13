using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Pessoas
{
    public class Torcedor : Pessoa
    {
        //Atributos
        protected string Tipo = "torcedor";

        //Construtor
        public Torcedor(string nome, string cpf, string celular) 
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
