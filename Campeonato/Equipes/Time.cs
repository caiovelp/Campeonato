using Campeonato.Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Equipes
{
    public class Time : IListaCompetidoresEmUmTime
    {
        //Atributos
        public string Nome { get; private set; }
        public int TotalMembrosTime { get; private set; }
        private List<Competidor> _membrosTime = new List<Competidor>();

        //Construtor
        public Time(string nome)
        {
            Nome = nome;
        }

        //Métodos
        public void RegistrarCompetidor(Competidor competidor)
        {
            if(IListaCompetidoresEmUmTime._participantes.Contains(competidor)) {

                Console.WriteLine($"{competidor.Nome} já foi adicionado no campeonato. " +
                    $"Não é permitido registrar o mesmo partipante 2 vezes");
            }
            else
            {
                _membrosTime.Add(competidor);
                IListaCompetidoresEmUmTime.AdicionarParticipante(competidor);
                TotalMembrosTime++;
            }

        }

        public void RegistrarCompetidores(params Competidor[] competidores)
        {
            foreach(Competidor competidor in competidores)
            {
                RegistrarCompetidor(competidor);
            }
        }

        public void RemoverCompetidor(Competidor competidor)
        {
            if (IListaCompetidoresEmUmTime._participantes.Contains(competidor))
            {
                _membrosTime.Remove(competidor);
                IListaCompetidoresEmUmTime.RemoverParticipante(competidor);
                TotalMembrosTime--; 
            }
            else
            {
                Console.WriteLine($"Não há ninguém chamado {competidor.Nome} na lista do time.");
            }
        }
        public void RemoverCompetidores(params Competidor[] competidores)
        {
            foreach (Competidor competidor in competidores)
            {
                RemoverCompetidor(competidor);
            }
        }

        public void ExibeInfo()
        {
            Console.WriteLine("Nome do time: " + Nome);
            Console.WriteLine("Pessoas no time: " + TotalMembrosTime);
        }

        public void ExibeListaTime()
        {
            Console.WriteLine($"LISTA DE MEMBROS DO TIME {Nome.ToUpper()} POR ORDEM ALFABÉTICA");
            _membrosTime.Sort((x, y) => x.Nome.CompareTo(y.Nome));
            _membrosTime.ForEach(i => Console.WriteLine(i.ToString()));
        }

    }
}
