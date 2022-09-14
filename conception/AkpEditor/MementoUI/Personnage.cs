using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoUI
{
    public class Personnage
    {
        private int defense;
        private int attaque;
        private int chance;

        public Personnage()
        {
            defense = 1;
            attaque = 1;
            chance = 1;
        }

        public int GetDefense()
        {
            return defense;
        }

        public void AugmenterDefense()
        {
            defense++;

            Random rd = new Random();
            if (rd.Next(2) == 1)
            {
                chance++;
            }
        }

        public int GetAttaque()
        {
            return attaque;
        }

        public void AugmenterAttaque()
        {
            attaque++;
        }

        public int GetChance()
        {
            return chance;
        }

public InstantanePersonnage CreerInstantane()
{
    return new InstantanePersonnage(
        defense,
        attaque,
        chance
    );
}

public void RestaurerInstantane(
    InstantanePersonnage instantane
)
{
    defense = instantane.defense;
    attaque = instantane.attaque;
    chance = instantane.chance;
}
    }
}
