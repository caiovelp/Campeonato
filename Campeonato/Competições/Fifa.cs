using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public class Fifa : Competicao
    {
        //Atributos
        protected string Tipo = "Individual";
        protected string Modalidade = "Fifa";

        //Construtor
        public Fifa(double premio) : base(premio)
        {

        }

        //Métodos
        public override void ExibeInfo()
        {
            Console.WriteLine(Modalidade);
            Console.WriteLine("Tipo de competição: " + Tipo);
            Console.WriteLine("Premio da competição: R$" + Premio.ToString("N2"));
        }
    }
}
