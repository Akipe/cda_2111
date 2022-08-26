using DesignPatternCommand.TelecommandeSimple;
using DesignPatternCommand.TelecommandeSimple.Choses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeSimple.Commandes
{
    public class CommandeOuvrirPorteGarage : ICommande
    {
        private readonly PorteGarage _porteGarage;

        public CommandeOuvrirPorteGarage(PorteGarage porteGarage)
        {
            _porteGarage = porteGarage;
        }

        public void Executer()
        {
            _porteGarage.Ouvrir();
        }
    }
}
