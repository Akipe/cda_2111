using System.ComponentModel;
using System.Diagnostics;
using LoanCourse.Models;

namespace LoanCourse
{
    public partial class Form1 : Form
    {
        public int NbMonths { get; set; }
        public int Period { get; set; }
        public Loan Loan { get; set; }

        public Form1()
        {
            InitializeComponent();
            Loan = Loan.GetInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loan.OnUpdate += LoanUpdated;
        }

        private void tbxCapital_TextChanged(object sender, EventArgs e)
        {
            long capital;

            if (!long.TryParse(tbxCapital.Text, out capital))
            {
                Debug.WriteLine("Capital not parsed");

                return;
            }

            Loan.CapitalLoan = capital;

            /*foreach (Control ctr in gbxInterests.Controls)
            {
                RadioButton rb = (RadioButton)ctr;

                if (rb.Checked)
                {
                    labelRepaymentAmount.Text = (
                        capital + capital * float.Parse(rb.Tag.ToString())).ToString();
                }
            }*/

        }

        private void RbInterestAnnual_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb)
            {
                Loan.SetAnnualInterestRate(float.Parse(rb.Tag.ToString()));
            }
        }

        private void LoanUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Loan loanModel)
            {
                labelNbRepayment.Text = loanModel.NumberRepayments.ToString();
                labelRepaymentAmount.Text = loanModel.GetSumPerPeriodicity().ToString();
            }
        }
    }
}