using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoUI
{
public class InstantanePersonnage
{
    public int defense;
    public int attaque;
    public int chance;

    public InstantanePersonnage(
        int defense,
        int attaque,
        int chance
    )
    {
        this.defense = defense;
        this.attaque = attaque;
        this.chance = chance;
    }

    public int GetDefense()
    {
        return defense;
    }

    public int GetAttaque()
    {
        return attaque;
    }

    public int GetChance()
    {
        return chance;
    }
}
}
