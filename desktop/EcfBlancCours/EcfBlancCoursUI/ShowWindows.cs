using EcfBlancCoursCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcfBlancCoursUI
{
    public partial class ShowWindows : Form
    {
        private JobSeeker _jobSeeker;
        private Form _parentForm;

        public ShowWindows()
        {
            InitializeComponent();
        }

        private void ShowWindows_Load(object sender, EventArgs e)
        {

        }

        public void SetJobSeeker(JobSeeker jobSeeker)
        {
            _jobSeeker = jobSeeker;

            lIdJobSeeker.Text = String.Format("Demandeur n°{0} ajouté en {1}s", jobSeeker.Id, jobSeeker.RegistrationYear);
            tbFirstName.Text = _jobSeeker.FirstName;
            tbLastName.Text = _jobSeeker.LastName;
            tbLevel.Text = _jobSeeker.Level.ToString();
            tbYearRegistered.Text = _jobSeeker.RegistrationYear.ToString();
            tbDiplomaName.Text = _jobSeeker.LastDiplomaName;
            tbDiplomaYear.Text = _jobSeeker.LastDiplomaYear.ToString();
            tbEmployability.Text = _jobSeeker.Employability; 
        }

        public void SetParentForm(Form originForm)
        {
            _parentForm = originForm;
        }

        private void ShowWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_jobSeeker);
            MessageBox.Show(json);

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            string jsonPath = Path.Combine(appDataPath, $"jobseeker-{_jobSeeker.Id.ToString()}.json");

            File.WriteAllText(jsonPath, json, Encoding.UTF8);

            string jsonFromFile = File.ReadAllText(jsonPath, Encoding.UTF8);

            //JobSeeker toto = JsonSerializer.Deserialize<JobSeeker>(json);

            MessageBox.Show(jsonFromFile);
            MessageBox.Show(jsonFromFile);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
