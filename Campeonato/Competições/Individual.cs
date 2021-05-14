using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public class Individual : Competicao
    {
        //Parâmetros
        public string Tipo = "Individual";

        //Construtor
        public Individual(string modalidade) : base(modalidade)
        {

        }

        //Métodos
        public override void ExibeInfo()
        {
            Console.WriteLine(Modalidade);
            Console.WriteLine("Tipo de competição: " + Tipo);
        }
    }
}
