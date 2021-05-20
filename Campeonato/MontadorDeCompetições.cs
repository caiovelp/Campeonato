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
        static void MontaCompeticoes()
        {
            var arquivo = "competicoes.txt";

            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var competicao = ConverterStringParaCompeticao(linha);
                }

            }

        }

        static Competicao ConverterStringParaCompeticao(string linha)
        {
            var campos = linha.Split(',');

            var nome = campos[0];
            var tipo = campos[1];

            var tipoComInt = int.Parse(tipo);

            var resultado = new Competicao(nome, tipoComInt);

            return resultado;
        }
    }
}