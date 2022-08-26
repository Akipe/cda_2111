using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCommand.TelecommandeComplexe
{
    /// <summary>
    /// Permet de gérer une liste de commandes,
    /// Cet objet peut être utiliser comme une simple commande
    /// </summary>
    public class MacroCommandes : ICommande
    {
        ICommande[] _commandes;

        public MacroCommandes(ICommande[] commandes)
        {
            _commandes = commandes;
        }

        public void Executer()
        {
            foreach(ICommande commande in _commandes)
            {
                commande.Executer();
            }
        }

        public void Annuler()
        {
            foreach (ICommande commande in _commandes)
            {
                commande.Annuler();
            }
        }
    }
}
