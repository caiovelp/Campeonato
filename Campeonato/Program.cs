using Campeonato.Competições;
using Campeonato.Equipes;
using Campeonato.Pessoas;
using System;

namespace Campeonato
{
    

    class Program
    {
        static public void PulaLinha()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Pessoas
            Competidor Caio = new Competidor("Caio Paranhos", "15957279730", "21995636965");
            Competidor Mylena = new Competidor("Mylena Leite", "15452030751", "21976948862");
            Competidor Elias = new Competidor("Elias Silva", "94811974336", "64999018878");
            Competidor Nina = new Competidor("Nina Almeida", "29899579793", "21985038933");
            Competidor Elza = new Competidor("Elza Barros", "68349901780", "21997588342");
            Competidor Jonas = new Competidor("Jonas Soares", "00191988766", "2187546263");

            PulaLinha();

            //Equipes
            Time Azul = new Time("Azul");

            Azul.RegistrarCompetidores(Nina, Elza);

            Azul.ExibeListaTime();
            PulaLinha();

            Time Amarelo = new Time("Amarelo");

            Amarelo.RegistrarCompetidores(Mylena, Elias);

            Amarelo.ExibeListaTime();
            PulaLinha();

            Time Vermelho = new Time("Vermelho");

            Vermelho.RegistrarCompetidores(Caio);

            Vermelho.ExibeListaTime();
            PulaLinha();

            Time Verde = new Time("Verde");

            IListaCampeonato.ExibeParticipantes();
            IListaCompetidores.ExibeListaCompetidores();


            

            PulaLinha();

            //Competições
            Competicao fifa = new Individual("Fifa");



        }
    }
}
