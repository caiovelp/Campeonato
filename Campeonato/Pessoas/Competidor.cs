﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Pessoas
{
    public class Competidor : Pessoa
    {
        public string Tipo = "competidor";

        public Competidor(string nome, string cpf, string email) 
            : base(nome, cpf, email)
        {

        }

        public override void ExibeInfo()
        {
            Console.WriteLine("Nome do " + Tipo + ": " + Nome);
            Console.WriteLine("CPF do " + Tipo + ": " + CPF);
            Console.WriteLine("E-mail do " + Tipo + ": " + Email);
        }
    }
}
