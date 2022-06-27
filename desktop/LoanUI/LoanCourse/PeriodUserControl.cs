using LoanCourse.Loan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCourse
{
    public partial class PeriodUserControl : UserControl
    {
        public event PropertyChangedEventHandler OnValuesUpdated;

        public int NbMonths
        {
            get
            {
                return scrollbarNbMonth.Value;
            }
        }

        public int Period
        {
            get
            {
                return periodicityUsed[lbPeriodicity.SelectedIndex].HowManyMonths;
            }
        }

        public readonly Periodicity[] periodicityUsed = new Periodicity[]
        {
            new Periodicity("Mensuelle", 1),
            new Periodicity("Bimestrielle", 2),
            new Periodicity("Trimestrielle", 3),
            new Periodicity("Semestrielle", 6),
            new Periodicity("Annuelle", 12)
        };

        private void ExecuteOnValuesUpdated()
        {
            if (OnValuesUpdated is not null)
            {
                OnValuesUpdated(this, new PropertyChangedEventArgs(nameof(Period)));
            }
        }

        public PeriodUserControl()
        {
            InitializeComponent();
        }

        private void PeriodUserControl_Load(object sender, EventArgs e)
        {
            lbPeriodicity.DataSource = periodicityUsed;

        }

        private void lbPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            scrollbarNbMonth.Minimum = Period;
            scrollbarNbMonth.SmallChange = Period;
            scrollbarNbMonth.LargeChange = Period * 2;
            scrollbarNbMonth.Maximum = 
                360 + scrollbarNbMonth.LargeChange - 1;
            scrollbarNbMonth.Value = Period;

            scrollbarNbMonth_ValueChanged(sender, new EventArgs());
        }

        private void scrollbarNbMonth_ValueChanged(object sender, EventArgs e)
        {
            labelNbMonth.Text = scrollbarNbMonth.Value.ToString();

            ExecuteOnValuesUpdated();
        }
    }
}
e