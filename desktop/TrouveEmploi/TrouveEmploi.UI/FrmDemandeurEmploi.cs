using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrouveEmploi.UI
{
    public partial class FrmDemandeurEmploi : Form
    {
        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void FrmDemandeurEmploi_Load(object sender, EventArgs e)
        {

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (false == true)
            {
                Hide();

                Form showJobSeeker = new FrmAffichageDemandeurEmploi();
                showJobSeeker.ShowDialog();

                Close();
            }
            else
            {
                MessageBox.Show(
                    "Erreur: veuillez remplir correctement le formulaire",
                    "Formulaire invalide",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
        }
    }
}
