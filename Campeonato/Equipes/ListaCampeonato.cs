using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Equipes
{
    public class ListaCampeonato
    {
        protected static List<Competidor> _participantes = new List<Competidor>();
        public static int TotalParticipantesCampeonato { get; private set; }

        public static void AdicionarParticipante(Competidor competidor)
        {
            _participantes.Add(competidor);
            TotalParticipantesCampeonato++;
        }

        public static void RemoverParticipante(Competidor competidor)
        {
            _participantes.Remove(competidor);
            TotalParticipantesCampeonato--;
        }

        public static void ExibeParticipantes()
        {
            Console.WriteLine($"MOSTRANDO {TotalParticipantesCampeonato} PARTICIPANTES DO CAMPEONATO POR ORDEM ALFABÉTICA");
            _participantes.Sort((x, y) => x.Nome.CompareTo(y.Nome));
            _participantes.ForEach(i => Console.WriteLine(i.InfoCompleta()));
        }
    }
}
