using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Competições
{
    public class Futebol : Competicao
    {
        //Atributos
        public string Tipo = "Em equipe";

        //Construtor
        public Futebol(int numero, double premio) : base(numero, premio)
        {

        }

        //Métodos
        public override void ExibeInfo()
        {
            Console.WriteLine("FUTEBOL");
            Console.WriteLine("Tipo de competição: " + Tipo);
            Console.WriteLine("Número de equipes: " + Numero);
            Console.WriteLine("Premio da competição: R$" + Premio.ToString("N2"));
        }
    }
}
