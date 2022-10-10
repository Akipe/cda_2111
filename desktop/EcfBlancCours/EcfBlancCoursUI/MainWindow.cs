using EcfBlancCoursCore;
using EcfBlancCoursCore.ViewModel;

namespace EcfBlancCoursUI
{
    public partial class MainWindow : Form
    {
        JobSeekerViewModel viewModel;
        JobSeeker jobSeeker;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            cbxLevel.DataSource = Enum.GetNames<Levels>();
            cbxLevel.SelectedIndex = 0;
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel = new JobSeekerViewModel()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Level = (Levels)Enum.Parse<Levels>(cbxLevel.SelectedItem.ToString()),
                    LastDiplomaName = tbDiplomaName.Text,
                    //LastDiplomaYear = Convert.ToInt32(tbDiplomaYear.Text),
                    RegistrationYear = DateTime.Now.Year
                };

                if (String.IsNullOrWhiteSpace(tbDiplomaYear.Text))
                {
                    viewModel.LastDiplomaYear = null;
                }
                else
                {
                    viewModel.LastDiplomaYear = Convert.ToInt32(tbDiplomaYear.Text);
                }

                if (viewModel.IsValid())
                {
                    jobSeeker = new JobSeeker(viewModel);

                    ShowWindows frm = new ShowWindows();
                    frm.SetJobSeeker(jobSeeker);
                    frm.SetParentForm(this);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    DisplayErrors();
                }
            }
            catch (Exception ex)
            {
                DisplayErrors();
            }
        }

        private void DisplayErrors()
        {
            SetErrorStatus(tbFirstName, viewModel.IsValidFirstName());
            SetErrorStatus(tbLastName, viewModel.IsValidLastName());
            SetErrorStatus(tbDiplomaName, viewModel.IsValidLastDiplomaName());
            SetErrorStatus(tbDiplomaYear, viewModel.IsValidLastDiplomaYear());
        }

        private void SetControlError(Control control)
        {
            control.BackColor = Color.Red;
            control.ForeColor = Color.Blue;
            control.Font = new Font(control.Font, FontStyle.Bold);
        }

        private void SetErrorStatus(Control control, bool isCorrect)
        {
            if (isCorrect)
            {
                control.ForeColor = Color.Blue;
                control.Font = new Font(control.Font, FontStyle.Regular);
            }
            else
            {
                control.ForeColor = Color.Red;
                control.Font = new Font(control.Font, FontStyle.Bold);
            }
        }
    }
}