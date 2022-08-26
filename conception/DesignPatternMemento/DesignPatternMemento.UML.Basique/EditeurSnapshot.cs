using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.Basique
{
    public class EditeurSnapshot : IMemento
    {
        public DateTime DateCreation { get; init; }
        public string Nom { get; init; }
        public string Contenu { get; init; }
        public string StyleSelectionne { get; init; }

        public EditeurSnapshot(
            string contenu,
            string styleSelectionne
        )
        {
            Contenu = contenu;
            StyleSelectionne = styleSelectionne;
            DateCreation = DateTime.Now;
            Nom = 
                "EditeurSnapshot"
                + DateCreation.ToShortDateString()
                + " "
                + DateCreation.ToShortTimeString()
            ;
        }

        public DateTime GetDateCreation()
        {
            return DateCreation;
        }

        public string GetNom()
        {
            return Nom;
        }
    }
}
