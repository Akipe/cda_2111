using DesignPatternCommand.TelecommandeComplexe;
using DesignPatternCommand.TelecommandeComplexe.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe.Commandes
{
    public class CommandeOuvrirPorteGarage : ICommande
    {
        private readonly PorteGarage _porteGarage;

        public CommandeOuvrirPorteGarage(PorteGarage porteGarage)
        {
            _porteGarage = porteGarage;
        }

        public void Annuler()
        {
            _porteGarage.Fermer();
        }

        public void Executer()
        {
            _porteGarage.Ouvrir();
        }
    }
}
