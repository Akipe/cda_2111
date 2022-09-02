using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationCommande
{
    public class ZoneSaisie : TextBox
    {
        public ZoneSaisie() : base()
        {
            Text = "Ceci est un article pour la demo :)";
        }

        public void MettreEnGras()
        {
            FontStyle fontActuelle = Font.Style;

            Font = new Font(
                Font, fontActuelle |= FontStyle.Bold
            );
        }

        public void MettreEnItalique()
        {
            FontStyle fontActuelle = Font.Style;

            Font = new Font(
                Font, fontActuelle |= FontStyle.Italic
            );
        }

        public void ChangerTaillePolice(int taille)
        {
            Font = new Font(
                Font.Name,
                taille,
                Font.Style
            );
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
    }
}
