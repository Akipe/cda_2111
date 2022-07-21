using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrouveEmploi.UI.Core.Persons;
using TrouveEmploi.UI.Input;

namespace TrouveEmploi.UI
{
    public partial class FrmDemandeurEmploi : Form
    {
        private PeopleInput peopleI;
        private DiplomaInput diplomaI;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void FrmDemandeurEmploi_Load(object sender, EventArgs e)
        {
            peopleI = new PeopleInput(
                tbFirstName,
                tbLastName,
                numRegisterYear,
                cbFormationLevel
            );
            diplomaI = new DiplomaInput(
                cbDiplomaName,
                numDiplomaYear
            );

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            JobSeeker jobSeeker = peopleI.GetJobSeeker();
            diplomaI.UpdateJobKeeper(jobSeeker);

            if (true == true) // todo
            {
                Hide();

                FrmAffichageDemandeurEmploi showJobSeeker = new FrmAffichageDemandeurEmploi();
                showJobSeeker.SetJobSeeker(jobSeeker);
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
