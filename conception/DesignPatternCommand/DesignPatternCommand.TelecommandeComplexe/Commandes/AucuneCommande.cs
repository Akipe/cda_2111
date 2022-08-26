using DesignPatternCommand.TelecommandeComplexe;
using DesignPatternCommand.TelecommandeComplexe.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Commandes
{
    // C'est un objet null
    public class AucuneCommande : ICommande
    {
        public AucuneCommande()
        {
        }

        public void Annuler()
        {
        }

        public void Executer()
        {
        }
    }
}
