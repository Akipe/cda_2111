using System.Diagnostics;

namespace LoanCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxCapital_TextChanged(object sender, EventArgs e)
        {
            long capital;

            if (!long.TryParse(tbxCapital.Text, out capital))
            {
                Debug.WriteLine("Capital not parsed");

                return;
            }

            foreach (Control ctr in gbxInterests.Controls)
            {
                RadioButton rb = (RadioButton)ctr;

                if (rb.Checked)
                {
                    labelRepaymentAmount.Text = (
                        capital + capital * float.Parse(rb.Tag.ToString())).ToString();
                }
            }
        }
    }
}