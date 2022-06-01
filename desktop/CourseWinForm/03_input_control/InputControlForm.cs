using System.Media;
using System.Text;
using System.Diagnostics;

namespace _03_input_control
{
    public partial class InputControlesForm : Form
    {
        private Boolean IsValid { get; set; }

        public InputControlesForm()
        {
            InitializeComponent();

            this.IsValid = true;
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            this.IsValid = true;

            this.CheckNameInput();
            this.CheckDateInput();
            this.CheckAmountInput();
            this.CheckZipcodeInput();

            if (this.IsValid)
            {
                this.ShowResult();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void CheckNameInput()
        {
            StringBuilder errorMessage = new StringBuilder();

            if (this.TbName.Text.Length == 0)
            {
                errorMessage.AppendLine("Veuillez entrer un nom");
            }
            if (this.TbName.Text.Length > 30)
            {
                errorMessage.AppendLine(
                    "Veuillez entrer un nom inférieur à 30 caractères"
                );
            }

            ShowInputErrorIfExist((Control)TbName, errorMessage.ToString());
        }

        private void CheckDateInput()
        {
            StringBuilder errorMessage = new StringBuilder();

            if (MtbDate.MaskFull)
            {
                if ((DateTime)MtbDate.ValidateText() <= DateTime.Now)
                {
                    errorMessage.AppendLine(
                        "Veuillez définir une date supérieur à la date du jour"
                    );
                }
            }
            else
            {
                errorMessage.AppendLine(
                    "Veuillez définir une date compléte (JJ/MM/AAAA)"
                );
                // MtbDate.BeepOnError = true;
            }

            this.ShowInputErrorIfExist(
                (Control)MtbDate,
                errorMessage.ToString()
            );
        }

        private void CheckAmountInput()
        {
            StringBuilder errorMessage = new StringBuilder();
            string amountEntered = this.ReplacePointToComa(this.TbAmount.Text);

            if (amountEntered.Length == 0)
            {
                errorMessage.AppendLine(
                    "Veuillez entrer un montant"
                );
            }
            else if (Decimal.TryParse(amountEntered, out decimal amount))
            {
                if (amount < 0)
                {
                    errorMessage.AppendLine(
                        "Veuillez entrer un montant supérieur ou égale à 0"
                    );
                }
            } else
            {
                errorMessage.AppendLine(
                    "Veuillez entrer uniquement un nombre"
                );
            }

            this.ShowInputErrorIfExist(
                (Control)TbAmount,
                errorMessage.ToString()
            );
        }

        private string ReplacePointToComa(string sentence)
        {
            return sentence.Replace('.', ',');
        }

        private void CheckZipcodeInput()
        {
            StringBuilder errorMessage = new StringBuilder();

            if (!this.MtbZipcode.MaskFull)
            {
                errorMessage.AppendLine(
                    "Veuillez définir un code postal sur 5 chiffres"
                );
            }

            this.ShowInputErrorIfExist(
                (Control)MtbZipcode,
                errorMessage.ToString()
            );
        }

        private void ShowInputErrorIfExist(Control inputElement, string message)
        {
            if (message.Length > 0)
            {
                errorProvider1.SetError(
                    inputElement, message
                );
                this.IsValid = false;
            }
        }

        private void ShowResult()
        {
            StringBuilder message = new StringBuilder();

            message.Append("Nom : ");
            message.AppendLine(TbName.Text);
            message.Append("Date : ");
            message.AppendLine(MtbDate.Text);
            message.Append("Montant : ");
            message.AppendLine(TbAmount.Text);
            message.Append("Code : ");
            message.AppendLine(MtbZipcode.Text);

            MessageBox.Show(
                message.ToString(),
                "Validation effectuée",
                MessageBoxButtons.OK
            );
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxBase[] allInputs =
            {
                TbName,
                MtbDate,
                TbAmount,
                MtbZipcode
            };

            this.ClearContentInput(allInputs);
        }

        private void ClearContentInput(TextBoxBase[] elements)
        {
            foreach (TextBoxBase element in elements)
            {
                element.Text = "";
            }
        }

        private void InputControlesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.AskUserIfReallyWantClose() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private DialogResult AskUserIfReallyWantClose()
        {
            return MessageBox.Show(
                "Fin de l'application",
                "FIN",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }

        private void TbName_Leave(object sender, EventArgs e)
        {
            //this.IsValid = true;

            this.CheckNameInput();
        }

        private void MtbDate_Leave(object sender, EventArgs e)
        {
            this.CheckDateInput();
        }

        private void TbAmount_Leave(object sender, EventArgs e)
        {
            this.CheckAmountInput();
        }

        private void MtbZipcode_Leave(object sender, EventArgs e)
        {
            this.CheckZipcodeInput();
        }
    }
}