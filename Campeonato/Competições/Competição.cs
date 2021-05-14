using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public abstract class Competicao
    {
        //Atributos
        public string Modalidade { get; private set; }

        protected static int TotalCompeticoes { get; set; }

        //Construtor
        public Competicao(string modalidade)
        {
            Modalidade = modalidade;

            TotalCompeticoes++;
        }

        //Métodos
        public static void ExibeTotalCompeticoes()
        {
            Console.WriteLine("Total de Competições: " + TotalCompeticoes);
        }

        public abstract void ExibeInfo();
    }
}
