using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class SauvegardePersonnage
    {
        private Personnage perso;
        public int Defence { get; private set; }
        public int Attaque { get; private set; }
        public int Chance { get; private set; }

        public SauvegardePersonnage(Personnage perso)
        {

        }

public void FaireSauvegarde()
{
    Defence = perso.GetDefence;
    Attaque = perso.GetAttaque;
    Chance = perso.DoNotUseGetChange;
}
    }
}
