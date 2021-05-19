using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Pessoas
{
    public interface IListaCompetidores
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
            Console.WriteLine("LISTA DE COMPETIDORES INSCRITOS NO CAMPEONATO POR ORDEM ALFABÉTICA");
            _competidores.Sort((x, y) => x.Nome.CompareTo(y.Nome));
            _competidores.ForEach(i => Console.WriteLine(i.ToString()));
        }
    }
}
