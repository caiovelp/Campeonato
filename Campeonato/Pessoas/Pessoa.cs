using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if(ValidarCPF(cpf))
            {
                CPF = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            } else
            {
                Console.WriteLine($"CPF de {nome} inválido: {cpf}");
            }
            Celular = Convert.ToUInt64(celular).ToString(@"(00) 00000\-0000");

            TotalDePessoas++;
        }

        //Métodos
        public static void ExibeTotalPessoas()
        {
            Console.WriteLine("Número de pessoas presentes: " + TotalDePessoas);
        }
        public abstract void ExibeInfo();
        public override string ToString()
        {
            return Nome + ", Contato: " + Celular;
        }
        public string InfoCompleta()
        {
            return Nome + " / " + CPF + " / " + Celular;
        }
        public override bool Equals(object obj)
        {
            Pessoa pessoa = obj as Pessoa;

            if(pessoa == null)
            {
                return false;
            }

            return Nome == pessoa.Nome && CPF == pessoa.CPF && Celular == pessoa.Celular;
        }
        private static bool ValidarCPF(string CPF)
        {
            return new CPFValidator().IsValid(CPF);
        }

    }
}
