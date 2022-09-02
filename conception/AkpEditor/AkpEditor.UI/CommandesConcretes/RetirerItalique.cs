using AkpEditor.UI.Recepteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpEditor.UI.CommandesConcretes
{
    public class RetirerItalique : ICommande
    {
        private readonly RecepteurContenu _contenuEditeur;
        private Font _anciennePolice;
        private ToolStripItem _control;

        public RetirerItalique(RecepteurContenu contenuEditeur, ToolStripItem control)
        {
            _contenuEditeur = contenuEditeur;
            _control = control;
        }

        public void Executer()
        {
            _anciennePolice = _contenuEditeur.GetControl().Font;

            FontStyle stylePoliceActuelle = _contenuEditeur.GetControl().Font.Style;
            _contenuEditeur.GetControl().Font = new Font(
                _contenuEditeur.GetControl().Font,
                stylePoliceActuelle & ~FontStyle.Italic
            );
            _control.BackColor = Color.Empty;
            _control.Tag = false;
        }

        public void Annuler()
        {
            _contenuEditeur.GetControl().Font = _anciennePolice;
            _control.BackColor = Color.Gray;
            _control.Tag = true;
        }

        public string Description()
        {
            return "Retrait de l'italique";
        }
    }
}
