using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.AvecCommande
{
    public class Instantane
    {
        public readonly Editeur editeur;
        public readonly string contenu;
        public readonly DateTime tempsDerniereEdition;

        public Instantane(
            Editeur editeur,
            string contenu,
            DateTime tempsDerniereEdition
        )
        {
            this.editeur = editeur;
            this.contenu = contenu;
            this.tempsDerniereEdition = tempsDerniereEdition;
        }

        public void Restaurer()
        {
            editeur.Restaurer(this);
        }
    }
}
