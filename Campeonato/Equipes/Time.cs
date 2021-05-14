using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Equipes
{
    public class Time
    {
        //Atributos
        public string Nome { get; private set; }
        public int TotalParticipantesTime { get; private set; }

        public List<string> participantes = new List<string>();


        //Próximo passo: (MODELO GINCANA IFRJ Então quando eu chamar a informação de participantes de uma competição,
        //quero que mostre a equipe da qual ele faz parte.

        //Construtor
        public Time(string nome)
        {
            Nome = nome;
        }

        //Métodos
        public void RegistrarIndividuo(Competidor competidor)
        {
            if(participantes.Contains(competidor.Nome)) {

                Console.WriteLine(competidor.Nome + " Já foi adicionado. " +
                    "Não é permitido registrar o mesmo partipante 2 vezes");
            }
            else
            {
                participantes.Add(competidor.Nome);
                TotalParticipantesTime++;
            }

        }

        public void ExibeInfo()
        {
            Console.WriteLine("Nome do time: " + Nome);
            Console.WriteLine("Pessoas no time: " + TotalParticipantesTime);
        }

        public void ExibeListaTime()
        {
            Console.WriteLine("Participantes do time ordenados por nome");
            participantes.Sort();
            participantes.ForEach(i => Console.WriteLine(i));
        }
    }
}
