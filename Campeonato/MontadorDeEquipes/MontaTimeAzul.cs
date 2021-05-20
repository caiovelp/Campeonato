using Campeonato.Competições;
using Campeonato.Equipes;
using Campeonato.Listas;
using Campeonato.Pessoas;
using System;
using System.IO;
using System.Text;

namespace Campeonato
{
    partial class Program
    {
        static void MontaTimeAzul()
        {
            var arquivo = "timeAzul.txt";

            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                Time Azul = new Time("Azul");

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var competidor = ConverterStringParaCompetidor(linha);
                    Azul.RegistrarCompetidores(competidor);

                }

                Azul.ExibeListaTime();

            }

        }

        static Competidor ConverterStringParaCompetidor(string linha)
        {
            var campos = linha.Split(',');

            var nome = campos[0];
            var cpf = campos[1];
            var celular = campos[2];

            var resultado = new Competidor(nome, cpf, celular);

            return resultado;
        }
    }
}