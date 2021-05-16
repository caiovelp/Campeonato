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
            Console.WriteLine(Tipo.ToUpper());
            Console.WriteLine("Nome: " + Nome + ", CPF: " + CPF + ", Celular: " + Celular);
        }
    }
}
