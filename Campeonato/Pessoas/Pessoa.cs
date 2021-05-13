﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Pessoas
{
    public abstract class Pessoa
    {
        //Atributos
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Celular { get; private set; }

        protected static int TotalDePessoas { get; set; }

        //Construtor
        public Pessoa(string nome, string cpf, string celular)
        {
            Nome = nome;
            CPF = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            Celular = Convert.ToUInt64(celular).ToString(@"(00)00000\-0000");

            TotalDePessoas++;
        }

        //Métodos
        public static void ExibeTotalPessoas()
        {
            Console.WriteLine("Número de pessoas presentes: " + TotalDePessoas);
        }
        public abstract void ExibeInfo();
    }
}
