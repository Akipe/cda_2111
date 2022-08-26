using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeSimple
{
    /// <summary>
    /// Télécommande ne pouvant contenir qu'une seul commande à la fois.
    /// </summary>
    public class TelecommandeSimple
    {
        private ICommande _emplacement;

        /// <summary>
        /// Pour définir la commande à executer.
        /// </summary>
        /// <param name="commande"></param>
        public void SetCommande(ICommande commande)
        {
            _emplacement = commande;
        }

        /// <summary>
        /// Executé lorsqu'on presse un bouton de la télécommande
        /// </summary>
        public void boutonPresse()
        {
            _emplacement.Executer();
        }
    }
}
