using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCourse.Models
{
    public class Loan
    {
        private static Loan? instance = null;

        public static Loan GetInstance()
        {
            if (instance == null)
            {
                instance = new Loan();
            }

            return instance;
        }

        public event PropertyChangedEventHandler OnUpdate;

        private Loan()
        {
            CapitalLoan = 0;
            Periodicity = 1;
            AnnualInterestRate = 0.01f;
            NumberMonths = 1;
        }

        private long _capitalLoan;

        public long CapitalLoan
        {
            get => _capitalLoan;
            set
            {
                if (value > 0 && value < 10000000000)
                {
                    _capitalLoan = value;

                    Updated();
                }
            }
        }

        public int NumberRepayments
        {
            get
            {
                return (NumberMonths / Periodicity);
            }
        }


        /// <summary>
        /// Le nombre de mois total pour le remboursement
        /// </summary>
        public int NumberMonths
        {
            get;
            private set;
        }

        public void SetNumberMonths(int nbMonth)
        {
            if (nbMonth > 0 && nbMonth <= 360)
            {
                NumberMonths = nbMonth;
                Updated();
            }
        }

        private int _periodicity;

        /// <summary>
        /// La périodicité en mois
        /// </summary>
        public int Periodicity
        {
            get => default;
            set
            {
                _periodicity = value;
                Updated();
            }
        }

        public float AnnualInterestRate
        {
            get => default;
            private set { }
        }

        public void SetAnnualInterestRate(float newValue)
        {
            if (newValue > 0.0 && newValue < 1.0)
            {
                AnnualInterestRate = newValue;
                Updated();
            }
        }

        public int GetSumPerPeriodicity()
        {
            int val = 0;

            val = NumberMonths / Periodicity;

            return val;
        }

        private double PerdiodicityInterest
        {
            get
            {
                return (AnnualInterestRate / (12 / Periodicity));
            }
        }

        public double GetNumberRepayment()
        {
            return CapitalLoan * PerdiodicityInterest / (1.0 - Math.Pow(1.0 + PerdiodicityInterest, -NumberRepayments));
        }

        private void Updated()
        {
            if (OnUpdate is not null)
            {
                OnUpdate(this, new PropertyChangedEventArgs(nameof(_capitalLoan)));
            }
        }
    }
}
