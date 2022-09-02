using AkpEditor.UI.Recepteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpEditor.UI.CommandesConcretes
{
    public class ChangerTaille : ICommande
    {
        private readonly RecepteurContenu _contenuEditeur;
        private readonly float _taille;
        private float _taillePrecedent;

        public ChangerTaille(RecepteurContenu contenuEditeur, float taille)
        {
            _contenuEditeur = contenuEditeur;
            _taille = taille;
            _taillePrecedent = contenuEditeur.Font.Size;
        }

        public void Executer()
        {
            _taillePrecedent = _contenuEditeur.GetControl().Font.Size;
            Font nouvellePolice = new Font(
                _contenuEditeur.GetControl().Font.Name,
                _taille, _contenuEditeur.GetControl().Font.Style
            );
            _contenuEditeur.GetControl().Font = nouvellePolice;
        }

        public void Annuler()
        {
            Font precedentePolice = new Font(
                _contenuEditeur.GetControl().Font.Name,
                _taillePrecedent,
                _contenuEditeur.GetControl().Font.Style
            );
            _contenuEditeur.GetControl().Font = precedentePolice;
        }

        public string Description()
        {
            return "Changement de taille : " + _taille.ToString();
        }
    }
}
