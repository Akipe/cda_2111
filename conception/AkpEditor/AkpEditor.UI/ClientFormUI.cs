using AkpEditor.UI.CommandesConcretes;
using AkpEditor.UI.Recepteur;

namespace AkpEditor.UI
{
    public partial class ClientFormUI : Form
    {
        private InvocateurCommande _invocateurCommande;

        public ClientFormUI()
        {
            InitializeComponent();

            InitialiserInvocateur();

            cGras.Tag = false;
            cItalique.Tag = false;

            KeyPreview = true;
        }

        private void InitialiserInvocateur()
        {
            _invocateurCommande = new InvocateurCommande();
            _invocateurCommande.SetDescriptionControl(infoDerniereCommande);
            infoDerniereCommande.Text = String.Empty;
        }


        #region Commandes

        private void cCouleurNoire_Click(object sender, EventArgs e)
        {
            _invocateurCommande.Executer(
                new ChangerCouleur(recepteurContenu, Color.Black)
            );
        }

        private void cCouleurRouge_Click(object sender, EventArgs e)
        {
            _invocateurCommande.Executer(
                new ChangerCouleur(recepteurContenu, Color.Red)
            );
        }

        private void cCouleurVert_Click(object sender, EventArgs e)
        {
            _invocateurCommande.Executer(
                new ChangerCouleur(recepteurContenu, Color.Green)
            );
        }

        private void cCouleurOrange_Click(object sender, EventArgs e)
        {
            _invocateurCommande.Executer(
                new ChangerCouleur(recepteurContenu, Color.Orange)
            );
        }

        private void cAnnuler_Click(object sender, EventArgs e)
        {
            _invocateurCommande.AnnulerDerniereCommande();
        }

        #endregion Commandes

        private void cTailleAugmenter1_Click(object sender, EventArgs e)
        {
            _invocateurCommande.Executer(
                new ChangerTaille(recepteurContenu, recepteurContenu.GetControl().Font.Size + 1)
            );
        }

        private void cTailleDiminuer1_Click(object sender, EventArgs e)
        {
            _invocateurCommande.Executer(
                new ChangerTaille(recepteurContenu, recepteurContenu.GetControl().Font.Size - 1)
            );
        }

        private void cGras_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton tsb)
            {
                if (!(bool)tsb.Tag)
                {
                    _invocateurCommande.Executer(
                        new MettreEnGras(recepteurContenu, tsb)
                    );
                }
                else
                {
                    _invocateurCommande.Executer(
                        new RetirerGras(recepteurContenu, tsb)
                    );
                }
            }
        }

        private void cItalique_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton tsb)
            {
                if (!(bool)tsb.Tag)
                {
                    _invocateurCommande.Executer(
                        new MettreItalique(recepteurContenu, tsb)
                    );
                }
                else
                {
                    _invocateurCommande.Executer(
                        new RetirerItalique(recepteurContenu, tsb)
                    );
                }
            }
            
        }

        private void afficherHistorique_Click(object sender, EventArgs e)
        {
            HistoriqueUI historiqueUI = new HistoriqueUI();
            historiqueUI.SetHistorique(_invocateurCommande.GetDescriptionHistorique());
            historiqueUI.ShowDialog();
        }

        private void cTaillePersonalise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender is ToolStripTextBox textBox)
                {
                    if (int.TryParse(textBox.Text, out int taillePolice))
                    {
                        _invocateurCommande.Executer(
                            new ChangerTaille(recepteurContenu, taillePolice)
                        );
                    }
                }
            }
        }

        private void ClientFormUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                _invocateurCommande.AnnulerDerniereCommande();
            }
        }

        private void recepteurContenu_Load(object sender, EventArgs e)
        {

        }
    }
}