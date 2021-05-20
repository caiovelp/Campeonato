using Campeonato.Competições;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Listas
{
    public interface IListaCompeticoes
    {
        protected static List<Competicao> _competicoes = new List<Competicao>();
        public static int totalCompeticoes { get; protected set; }
        public static void AdicionaCompeticao(Competicao competicao)
        {
            if (_competicoes.Contains(competicao))
            {
                Console.WriteLine($"{competicao.Modalidade} já adicionado(a). Impossível adicionar 2x.");
            }
            else
            {
                _competicoes.Add(competicao);
                totalCompeticoes++;
            }
        }
        public static void ExibeListaCompeticoes()
        {
            Console.WriteLine();
            Console.WriteLine($"LISTA DE COMPETIÇÕES DO CAMPEONATO POR ORDEM ALFABÉTICA - Total de {totalCompeticoes}");
            _competicoes.Sort((x, y) => x.Modalidade.CompareTo(y.Modalidade));
            _competicoes.ForEach(i => i.ExibeInfo());
        }
    }
}
