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
            Console.WriteLine(Tipo.ToUpper());
            Console.WriteLine("Nome: " + Nome + ", CPF: " + CPF + ", Celular: " + Celular);
        }
    }
}
