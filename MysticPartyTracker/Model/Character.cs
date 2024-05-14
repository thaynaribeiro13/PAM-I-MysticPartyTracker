using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Character
    {
        public Character(string nomePersonagem, string classePersonagem, string racaPersonagem, int nivelPersonagem)
        {
            NomePersonagem = nomePersonagem;
            ClassePersonagem = classePersonagem;
            RacaPersonagem = racaPersonagem;
            NivelPersonagem = nivelPersonagem;
        }

        public string NomePersonagem { get; set; }
        public string ClassePersonagem { get; set; }
        public string RacaPersonagem { get; set; }
        public int NivelPersonagem { get; set; }
    }
}
