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
            Pessoa Caio = new Torcedor("Caio Paranhos", "159.572.797-30", "caio.hvparanhos@gmail.com");
            Pessoa Mylena = new Competidor("Mylena Leite", "154.520.307-51", "mylena-leite@hotmail.com");


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
