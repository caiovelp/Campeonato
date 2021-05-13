using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public abstract class Competicao
    {
        //Atributos
        public double Premio { get; private set; }

        protected static int TotalCompeticoes { get; set; }

        //Construtor
        public Competicao(double premio)
        {
            Premio = premio;

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
