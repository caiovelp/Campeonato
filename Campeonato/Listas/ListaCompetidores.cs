using Campeonato.Equipes;
using Campeonato.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campeonato.Pessoas
{
    public interface IListaCompetidores : IListaCompetidoresEmUmTime, IListaCompetidoresSemTime
    {
        protected static  List<Competidor> _competidores = new List<Competidor>();
        public static int TotalCompetidores { get; protected set; }

        public static void AdicionaCompetidor(Competidor competidor)
        {
            if (_competidores.Contains(competidor))
            {
                Console.WriteLine($"{competidor.Nome} já adicionado(a) como competidor. Impossível adicionar a mesma pessoa 2x.");
            }
            else
            {
                _competidores.Add(competidor);
                TotalCompetidores++;
            }
        }
        public static void ExibeListaCompetidores()
        {
            Console.WriteLine();
            Console.WriteLine($"LISTA DE COMPETIDORES INSCRITOS NO CAMPEONATO POR ORDEM ALFABÉTICA - Total de Competidores {TotalCompetidores}");
            _competidores.Sort((x, y) => x.Nome.CompareTo(y.Nome));
            _competidores.ForEach(i => Console.WriteLine(i.ToString()));
        }
        public static void ExibeNParticipantes()
        {
            Console.WriteLine();
            _nparticipantes = _competidores.Except(_participantes).ToList();
            Console.WriteLine($"MOSTRANDO {_nparticipantes.Count} PARTICIPANTES QUE NÃO ESTÃO EM UM TIME POR ORDEM ALFABÉTICA");
            _nparticipantes.Sort((x, y) => x.Nome.CompareTo(y.Nome));
            _nparticipantes.ForEach(i => Console.WriteLine(i.InfoCompleta()));
        }
        public static void ExibeParticipantes()
        {
            Console.WriteLine();
            Console.WriteLine($"MOSTRANDO {TotalParticipantesComTime} PARTICIPANTES QUE ESTÃO EM UM TIME POR ORDEM ALFABÉTICA");
            _participantes.Sort((x, y) => x.Nome.CompareTo(y.Nome));
            _participantes.ForEach(i => Console.WriteLine(i.InfoCompleta()));
        }
    }
}
