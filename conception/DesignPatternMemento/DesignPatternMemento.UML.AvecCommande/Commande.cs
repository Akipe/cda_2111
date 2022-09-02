using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.AvecCommande
{
    public class Commande
    {
        private Instantane _sauvegarde;
        private Editeur _editeur;

        public Commande(Editeur editeur)
        {
            _editeur = editeur;
        }

        public void Executer(ICommande commande)
        {
            CreerSauvegarde();
            commande.Executer();
        }

        public void CreerSauvegarde()
        {
            _sauvegarde = _editeur.CreerInstantane();
        }

        public void Annuler()
        {
            _sauvegarde.Restaurer();
        }
    }
}
