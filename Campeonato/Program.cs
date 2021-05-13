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
            Torcedor Caio = new Torcedor("Caio Paranhos", "15957279730", "21995636965");
            Competidor Mylena = new Competidor("Mylena Leite", "15452030751", "21976948862");


            Pessoa.ExibeTotalPessoas();
            PulaLinha();

            Caio.ExibeInfo();
            PulaLinha();
            Mylena.ExibeInfo();

            PulaLinha();

            //Competições
            Competicao competicao1 = new Fifa(1000.00);

            competicao1.Registrar(Mylena);

            Competicao.ExibeTotalCompeticoes();
            PulaLinha();

            competicao1.ExibeInfo();



        }
    }
}
