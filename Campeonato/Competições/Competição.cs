using Campeonato.Listas;
using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public class Competicao : IListaCompeticoes
    {
        //Atributos
        public string Modalidade { get; private set; }
        public int Tipo { get; private set; }
        public string Tipo2 { get; private set; }

        protected static int TotalCompeticoes { get; set; }

        //Construtor
        public Competicao(string modalidade, int tipo)
        {
            Modalidade = modalidade;
            Tipo = tipo;

            IListaCompeticoes.AdicionaCompeticao(this);
        }

        //Métodos
        public static void ExibeTotalCompeticoes()
        {
            Console.WriteLine("Total de Competições: " + TotalCompeticoes);
        }

        public bool VerificaTipo()
        {
            return Tipo == 1 || Tipo == 2;
        }

        public void ConverteTipo()
        {
            if(Tipo == 1)
            {
                Tipo2 = "Individual";
            } else
            {
                Tipo2 = "Coletivo";
            }
        }

        public void ExibeInfo()
        {
            ConverteTipo();
            Console.WriteLine($"A competição de {Modalidade} é do tipo {Tipo2}");
        }
    }
}
