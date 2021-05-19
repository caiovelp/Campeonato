using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Equipes
{
    public interface IListaCompetidoresEmUmTime
    {
        protected static List<Competidor> _participantes = new List<Competidor>();
        public static int TotalParticipantesComTime { get; private set; }

        public static void AdicionarParticipante(Competidor competidor)
        {
            _participantes.Add(competidor);
            TotalParticipantesComTime++;
        }

        public static void RemoverParticipante(Competidor competidor)
        {
            _participantes.Remove(competidor);
            TotalParticipantesComTime--;
        }


    }
}
