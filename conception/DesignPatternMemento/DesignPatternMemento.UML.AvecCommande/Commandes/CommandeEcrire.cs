using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMemento.UML.AvecCommande.Commandes
{
    public class CommandeEcrire : ICommande
    {
        private Editeur _editeur;
        private string _text;

        public CommandeEcrire(Editeur editeur, string text)
        {
            _editeur = editeur;
            _text = text;
        }

        public void Executer()
        {
            _editeur.Contenu += "\n";
            _editeur.Contenu += _text;
        }
    }
}
