using System.Diagnostics;

namespace LoanCourse
{
    public partial class Form1 : Form
    {
        public int NbMonths { get; set; }
        public int Period { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void periodUserControl1_Load(object sender, EventArgs e)
        {
            periodUserControl1.OnValuesUpdated += UpdatePeriodData;
            periodUserControl1.OnValuesUpdated += ShowMessageWhenPeriodUpdate;
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

        private void UpdatePeriodData(object sender, EventArgs e)
        {
            NbMonths = periodUserControl1.NbMonths;
            Period = periodUserControl1.Period;
        }

        private void ShowMessageWhenPeriodUpdate(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"number month : {periodUserControl1.NbMonths} and period : {periodUserControl1.Period}");
        }
    }
}