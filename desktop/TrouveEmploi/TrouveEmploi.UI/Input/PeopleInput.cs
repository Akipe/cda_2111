using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.UI.Core.Education;
using TrouveEmploi.UI.Core.Persons;
using TrouveEmploi.UI.Core.Validator;

namespace TrouveEmploi.UI.Input
{
    internal class PeopleInput : JobSeekerInput
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

        public bool IsValid()
        {
            bool isAllValid = true;

            if (NamesValidator.IsValid(_lastName.Text))
            {
                SetControlValid(_lastName);
            }
            else
            {
                SetControlInvalid(_lastName);
                isAllValid = false;
            }

            if (NamesValidator.IsValid(_firstName.Text))
            {
                SetControlValid(_firstName);
            }
            else
            {
                SetControlInvalid(_firstName);
                isAllValid = false;
            }

            if (RegisterYearValidator.IsValid((int)_registerYear.Value))
            {
                SetControlValid(_registerYear);
            }
            else
            {
                SetControlInvalid(_registerYear);
                isAllValid = false;
            }

            return isAllValid;
        }

        public JobSeeker GetJobSeeker()
        {
            return new JobSeeker(
                _firstName.Text.Trim(),
                _lastName.Text.Trim(),
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
    }
}
