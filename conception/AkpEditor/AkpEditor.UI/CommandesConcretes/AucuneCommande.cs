using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpEditor.UI.CommandesConcretes
{
    public class AucuneCommande : ICommande
    {
        public void Executer()
        {
        }

        public void Annuler()
        {
        }

        public string Description()
        {
            return "Aucune commande";
        }
    }
}
