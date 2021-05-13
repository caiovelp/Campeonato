using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Equipes
{
    public class Time
    {
        //Atributos
        public string Nome { get; private set; }

        //Próximo passo: (MODELO GINCANA IFRJ) Inves de registrar os competidores diretamente nas competições,
        //quero registrá-los nas equipes. Como o modelo é uma gincana, todas as equpes já estão participando
        //do campeonato de forma implícita. Então quando eu chamar a informação de participantes de uma competição,
        //quero que mostre a equipe da qual ele faz parte.

        //Construtor
        public Time(string nome)
        {
            Nome = nome;
        }
    }
}
