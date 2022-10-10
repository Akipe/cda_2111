using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrouveEmploi.Core.Persons;

namespace TrouveEmploi.UI
{
    public partial class FrmAffichageDemandeurEmploi : Form
    {
        private JobSeeker _jobSeeker;

        public FrmAffichageDemandeurEmploi()
        {
            InitializeComponent();
        }

        public void SetJobSeeker(JobSeeker jobSeeker)
        {
            _jobSeeker = jobSeeker;

            lTitle.Text = $"Utilisateur {jobSeeker.firstName} {jobSeeker.lastName}"; 

            lId.Text = jobSeeker.Id.ToString();
            tbFirstName.Text = jobSeeker.firstName;
            tbLastName.Text = jobSeeker.lastName;
            tbRegisterYear.Text = jobSeeker.registrationYear.ToString();
            tbFormationLevel.Text = jobSeeker.formation.name;

            if (jobSeeker.Diploma is not null)
            {
                tbDiplomaName.Text = jobSeeker.Diploma.ToString();
                tbDiplomaYear.Text = jobSeeker.DiplomaYear.ToString();
            }
            else
            {
                tbDiplomaName.Text = "Aucun";
                tbDiplomaYear.Text = "Non valide";
            }

            lEmployabilityRate.Text = 
                jobSeeker.formation.rateEmployementPercent.ToString()
                + " %";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAddMore_Click(object sender, EventArgs e)
        {
            FrmDemandeurEmploi frm = new FrmDemandeurEmploi();

            Hide();
            frm.ShowDialog();
            Close();
        }
    }
}
