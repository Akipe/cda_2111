using AkpEditor.UI.CommandesConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkpEditor.UI
{
    public class InvocateurCommande
    {
        private int? _indexHistoriqueUtilise;
        private List<ICommande> _historique;
        private ToolStripStatusLabel _controlStatus;

        public InvocateurCommande()
        {
            _indexHistoriqueUtilise = null;
            _historique = new List<ICommande>();
            _historique.Add(new AucuneCommande());
        }

        public void Executer(ICommande commande)
        {
            if (_indexHistoriqueUtilise is not null)
            {
                _indexHistoriqueUtilise = null;
                _historique.Clear();
            }

            commande.Executer();
            _historique.Add(commande);

            _controlStatus.Text = _historique.Last().Description();
        }

        public void AnnulerDerniereCommande()
        {
            if (_indexHistoriqueUtilise is null)
            {
                _indexHistoriqueUtilise = _historique.Count - 1;
            }
            else
            {
                _indexHistoriqueUtilise--;
            }

            if (_indexHistoriqueUtilise >= 0)
            {
                _historique[(int)_indexHistoriqueUtilise].Annuler();
                _controlStatus.Text = _historique[(int)_indexHistoriqueUtilise].Description();
            }

        }

        public List<string> GetDescriptionHistorique()
        {
            List<string> listeDescriptionCommandes = new List<string>();

            foreach(ICommande commande in _historique)
            {
                listeDescriptionCommandes.Add(commande.Description());
            }

            return listeDescriptionCommandes;
        }

        public void SetDescriptionControl(ToolStripStatusLabel controlStatus)
        {
            _controlStatus = controlStatus;
        }
    }
}
