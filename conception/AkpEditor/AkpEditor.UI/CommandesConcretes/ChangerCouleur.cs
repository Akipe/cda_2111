using AkpEditor.UI.Recepteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpEditor.UI.CommandesConcretes
{
    public class ChangerCouleur : ICommande
    {
        private readonly RecepteurContenu _contenuEditeur;
        private readonly Color _couleur;
        private Color _couleurPrecedent;

        public ChangerCouleur(RecepteurContenu contenuEditeur, Color couleur)
        {
            _contenuEditeur = contenuEditeur;
            _couleur = couleur;
            _couleurPrecedent = contenuEditeur.GetControl().ForeColor;
        }
        
        public void Executer()
        {
            _couleurPrecedent = _contenuEditeur.GetControl().ForeColor;
            _contenuEditeur.GetControl().ForeColor = _couleur;
        }

        public void Annuler()
        {
            _contenuEditeur.GetControl().ForeColor = _couleurPrecedent;
        }

        public string Description()
        {
            return "Changement de couleur : " + _couleur.ToString();
        }
    }
}
