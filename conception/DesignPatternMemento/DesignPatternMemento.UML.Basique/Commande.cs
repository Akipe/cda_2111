using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.Basique
{
    public class Commande
    {
        private Editeur _editeur;
        private Historique _historique;

        public Commande(
            Editeur editeur,
            Historique historique
        )
        {
            _editeur = editeur;
            _historique = historique;
        }

        public void AnnulerDerniereAction()
        {
            _editeur.RestaurerSnapshot(_historique.List.Last());
        }
    }
}
