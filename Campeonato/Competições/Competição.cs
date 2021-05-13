using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public class Competicao
    {
        //Atributos
        public string Modalidade { get; private set; }
        public string Tipo { get; private set; }
        public int Numero { get; private set; } //Numero de Equipes ou de Participantes
        public double Premio { get; private set; }

        public static int TotalCompeticoes { get; set; }

        //Construtor
        public Competicao(string modalidade, string tipo, int numero, double premio)
        {
            Modalidade = modalidade;
            Tipo = tipo;
            Numero = numero;
            Premio = premio;

            TotalCompeticoes++;
        }

        //Métodos
        public static void ExibeTotalCompeticoes()
        {
            Console.WriteLine("Total de Competições: " + TotalCompeticoes);
        }
    }
}
