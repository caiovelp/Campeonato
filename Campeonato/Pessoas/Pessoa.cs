using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Pessoas
{
    public abstract class Pessoa
    {
        //Atributos
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }

        public static int TotalDePessoas { get; set; }

        //Construtor
        public Pessoa(string nome, string cpf, string email)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;

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
