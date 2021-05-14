using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public class Coletiva : Competicao
    {
        //Parâmetros
        public string Tipo = "Coletiva";

        //Construtor
        public Coletiva(string modalidade) : base(modalidade)
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
