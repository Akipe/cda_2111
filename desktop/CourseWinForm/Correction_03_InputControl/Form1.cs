using LibValidationInput;
using System.Text.RegularExpressions;

namespace Correction_03_InputControl
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider;
        private NameValidation nameValidation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider = new ErrorProvider();
            nameValidation = new NameValidation();
        }

        private void BValidate_Click(object sender, EventArgs e)
        {
            if (!nameValidation.IsValid(TbName.Text))
            {
                errorProvider.SetError(TbName, "Le nom n'est pas valide");
            }
            else
            {
                errorProvider.SetError(TbName, String.Empty);
                MessageBox.Show("C'est ok", "Information");
            }
        }
    }
}