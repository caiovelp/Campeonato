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
            Pessoa Caio = new Torcedor("Caio Paranhos", "159.572.797-30", "caio.hvparanhos@gmail.com");


            Pessoa.ExibeTotalPessoas();
            PulaLinha();
            Caio.ExibeInfo();
        }
    }
}
