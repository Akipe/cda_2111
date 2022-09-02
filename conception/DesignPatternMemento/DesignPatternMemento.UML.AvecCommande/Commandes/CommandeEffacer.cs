using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.AvecCommande.Commandes
{
    public class CommandeEffacer : ICommande
    {
        private Editeur _editeur;

        public CommandeEffacer(Editeur editeur)
        {
            _editeur = editeur;
        }

        public void Executer()
        {
            _editeur.Contenu = String.Empty;
        }
    }
}
