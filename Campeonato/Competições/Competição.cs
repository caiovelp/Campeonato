using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public abstract class Competicao
    {
        //Atributos
        public int Numero { get; private set; } //Numero de Equipes ou de Participantes
        public double Premio { get; private set; }

        protected static int TotalCompeticoes { get; set; }

        //Construtor
        public Competicao(int numero, double premio)
        {
            Numero = numero;
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
