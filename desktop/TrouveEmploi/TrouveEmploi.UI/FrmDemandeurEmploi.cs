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
            if (IsFormValid())
            {
                JobSeeker jobSeeker = peopleI.GetJobSeeker();

                if (cbHasDiploma.Checked)
                {
                    diplomaI.UpdateJobKeeper(jobSeeker);
                }

                Hide();

                FrmAffichageDemandeurEmploi showJobSeeker = new FrmAffichageDemandeurEmploi();
                showJobSeeker.SetJobSeeker(jobSeeker);
                showJobSeeker.ShowDialog();

                Close();
            }
            else
            {
                MessageBox.Show(
                    "Veuillez corriger les erreurs du formulaire (texte en gras & rouge)",
                    "Formulaire invalide",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool IsFormValid()
        {
            bool isPeopleValid = peopleI.IsValid();
            bool isDiplomaValid = true;

            if (cbHasDiploma.Checked)
            {
                isDiplomaValid = diplomaI.IsValid();
            }
            
            return isPeopleValid && isDiplomaValid;
        }

        private void cbHasDiploma_CheckedChanged(object sender, EventArgs e)
        {
            cbDiplomaName.Enabled = cbHasDiploma.Checked;
            numDiplomaYear.Enabled = cbHasDiploma.Checked;
            label7.Enabled = cbHasDiploma.Checked;
            label8.Enabled = cbHasDiploma.Checked;
        }
    }
}
