using Campeonato.Competições;
using Campeonato.Equipes;
using Campeonato.Listas;
using Campeonato.Pessoas;
using System;
using System.IO;
using System.Text;

namespace Campeonato
{
    

    partial class Program
    {
        static public void PulaLinha()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MontaTimeAzul();

            IListaCompetidores.ExibeListaCompetidores();
            IListaCompetidores.ExibeParticipantes();
            IListaCompetidores.ExibeNParticipantes();

        }

    }
}
