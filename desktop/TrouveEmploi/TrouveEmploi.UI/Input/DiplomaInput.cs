using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.UI.Core.Education;
using TrouveEmploi.UI.Core.Persons;

namespace TrouveEmploi.UI.Input
{
    internal class DiplomaInput
    {
        private readonly ComboBox _name;
        private readonly NumericUpDown _year;

        public DiplomaInput(
            ComboBox name,
            NumericUpDown year
        )
        {
            _name = name;
            _year = year;

            InitName();
            InitYear();
        }

        public void UpdateJobKeeper(JobSeeker jobSeeker)
        {
            jobSeeker.SetDiploma(
                new Diploma(_name.Text),
                (int)_year.Value
            );
        }

        private void InitName()
        {
            foreach (Diploma diploma in Diploma.Register)
            {
                _name.Items.Add(diploma);
            }
        }

        private void InitYear()
        {

            int currentYear = int.Parse(
                DateTime.Now.ToString("yyyy")
            );

            _year.Minimum = currentYear - 66;
            _year.Maximum = currentYear;

            _year.Value = currentYear;
        }
    }
}
