using System.Text;

namespace _04_CheckboxRadio
{
    public partial class CRMainForm : Form
    {
        public CRMainForm()
        {
            InitializeComponent();
        }

        private void TbText_TextChanged(object sender, EventArgs e)
        {
            TriggerOptionsAvailability();
            UpdateTextShowed();
        }

        private void UpdateTextShowed()
        {
            LTextShow.Text = TbText.Text;

            SetTextCase();
            SetColorText();
            SetColorBackground();
        }

        private void TriggerOptionsAvailability()
        {
            GbOptions.Enabled = TbText.Text.Length > 0;

            if (!GbOptions.Enabled)
            {
                GbColorBackground.Enabled = false;
                GbColorText.Enabled = false;
                GbCase.Enabled = false;
            }
        }

        private void TriggerColorBackgroundAvailability()
        {
            GbColorBackground.Enabled = CbOptionColorBackground.Checked;
        }

        private void TriggerColorTextAvailability()
        {
            GbColorText.Enabled = CbOptionColorText.Checked;
        }

        private void TriggerCaseAvailability()
        {
            GbCase.Enabled = CbOptionCase.Checked;
        }

        private void CbOption_CheckedChanged(object sender, EventArgs e)
        {
            TriggerColorBackgroundAvailability();
            TriggerColorTextAvailability();
            TriggerCaseAvailability();

            UpdateTextShowed();
        }

        private void SetColorBackground()
        {
            Color backgroundColor = Color.Empty;

            if (GbColorBackground.Enabled)
            {
                if (RbColorBackgroundRed.Checked)
                {
                    backgroundColor = Color.Red;
                }
                if (RbColorBackgroundGreen.Checked)
                {
                    backgroundColor = Color.Green;
                }
                if (RbColorBackgroundBlue.Checked)
                {
                    backgroundColor = Color.Blue;
                }
            }

            LTextShow.BackColor = backgroundColor;
        }

        private void SetColorText()
        {
            Color textColor = Color.Empty;

            if (GbColorText.Enabled)
            {
                if (RbColorTextRed.Checked)
                {
                    textColor = Color.Red;
                }
                if (RbColorTextWhite.Checked)
                {
                    textColor = Color.White;
                }
                if (RbColorTextBlack.Checked)
                {
                    textColor = Color.Black;
                }
            }

            LTextShow.ForeColor = textColor;
        }

        private void SetTextCase()
        {
            if (GbCase.Enabled)
            {
                if (RbCaseLower.Checked)
                {
                    LTextShow.Text = LTextShow.Text.ToLower();
                }
                if (RbCaseUpper.Checked)
                {
                    LTextShow.Text = LTextShow.Text.ToUpper();
                }
            }
        }

        private void OptionsUpdates(object sender, EventArgs e)
        {
            UpdateTextShowed();
        }
    }
}

