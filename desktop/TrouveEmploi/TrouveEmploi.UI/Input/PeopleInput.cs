using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.UI.Core.Education;
using TrouveEmploi.UI.Core.Persons;

namespace TrouveEmploi.UI.Input
{
    internal class PeopleInput
    {
        private readonly TextBox _firstName;
        private readonly TextBox _lastName;
        private readonly NumericUpDown _registerYear;
        private readonly ComboBox _formations;

        public PeopleInput(
            TextBox firstName,
            TextBox lastName,
            NumericUpDown registerYear,
            ComboBox formations
        )
        {
            _registerYear = registerYear;
            _firstName = firstName;
            _lastName = lastName;
            _formations = formations;

            InitRegisterYear();
            InitFormation();
        }

        public JobSeeker GetJobSeeker()
        {
            return new JobSeeker(
                _firstName.Text,
                _lastName.Text,
                (int)_registerYear.Value,
                Formation.Parse(
                    _formations.SelectedItem.ToString()
                )
            );
        }

        private void InitRegisterYear()
        {
            int currentYear = int.Parse(
                DateTime.Now.ToString("yyyy")
            );

            _registerYear.Minimum = currentYear - 66;
            _registerYear.Maximum = currentYear;

            _registerYear.Value = currentYear;

        }

        private void InitFormation()
        {
            foreach (Formation formation in Formation.AVAILABLES)
            {
                _formations.Items.Add(formation);
            }

            _formations.SelectedIndex = 0;
        }

        /*private void SetFirstNameIn(TextBox tb)
        {
            int currentYear = int.Parse(
                DateTime.Now.ToString("yyyy")
            );

            numUd.Minimum = currentYear - 66;
            numUd.Maximum = currentYear;

            numUd.Value = currentYear;
        }

        private void SetLastNameIn(TextBox tb)
        {
            int currentYear = int.Parse(
                DateTime.Now.ToString("yyyy")
            );

            numUd.Minimum = currentYear - 66;
            numUd.Maximum = currentYear;

            numUd.Value = currentYear;
        }*/
    }
}
