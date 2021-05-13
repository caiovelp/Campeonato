using Campeonato.Competições;
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
            Pessoa Caio = new Torcedor("Caio Paranhos", "15957279730", "21995636965");
            Pessoa Mylena = new Competidor("Mylena Leite", "15452030751", "21976948862");


            Pessoa.ExibeTotalPessoas();
            PulaLinha();

            Caio.ExibeInfo();
            PulaLinha();
            Mylena.ExibeInfo();

            PulaLinha();

            //Competições
            Competicao Futebol = new Futebol(8, 1000.00);

            Competicao.ExibeTotalCompeticoes();
            PulaLinha();

            Futebol.ExibeInfo();



        }
    }
}
