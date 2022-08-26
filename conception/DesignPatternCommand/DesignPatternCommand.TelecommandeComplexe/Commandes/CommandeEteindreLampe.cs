using DesignPatternCommand.TelecommandeComplexe;
using DesignPatternCommand.TelecommandeComplexe.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Commandes
{
    public class CommandeEteindreLampe : ICommande
    {
        // Référence à l'objet sur lequel on execute les actions
        private readonly Lampe _lampe;

        public CommandeEteindreLampe(Lampe lampe)
        {
            _lampe = lampe;
        }

        public void Annuler()
        {
            _lampe.Marche();
        }

        public void Executer()
        {
            _lampe.Arret();
        }
    }
}
