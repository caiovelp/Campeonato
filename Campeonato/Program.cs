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
            Torcedor Caio = new Torcedor("Caio Paranhos", "15957279730", "21995636965");

            Competidor Mylena = new Competidor("Mylena Leite", "15452030751", "21976948862");
            Competidor Elias = new Competidor("Elias Silva", "94811974336", "64999018878");
            Competidor Nina = new Competidor("Nina Almeida", "29899579793", "21985038933");
            Competidor Elza = new Competidor("Elza Barros", "68349901780", "21997588342");

            PulaLinha();

            //Equipes
            Time Azul = new Time("Azul");

            Azul.RegistrarCompetidores(Mylena, Elias, Nina, Elza);

            Azul.ExibeInfo();
            PulaLinha();
            Azul.ExibeListaTime();
            PulaLinha();

            Time Amarelo = new Time("Amarelo");

            Amarelo.RegistrarCompetidores(Mylena, Elias);

            Amarelo.ExibeInfo();
            PulaLinha();
            Amarelo.ExibeListaTime();
            PulaLinha();

            Time.ExibeParticipantes();

            Time Vermelho = new Time("Vermelho");

            Time Verde = new Time("Verde");

            

            PulaLinha();

            //Competições
            Competicao fifa = new Individual("Fifa");



        }
    }
}
