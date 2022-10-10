using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.Core.Education;
using TrouveEmploi.Core.Persons;
using TrouveEmploi.Core.Validator;

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

            _registerYear.Minimum = decimal.MinValue;
            _registerYear.Maximum = decimal.MaxValue;
            /*_registerYear.Minimum = currentYear - JobSeeker.MAX_YEAR_FROM_NOW;
            _registerYear.Maximum = currentYear;*/

            _registerYear.Value = currentYear;


            _registerYear.ValueChanged += new EventHandler(numControl_ValueChanged);

        }

        private void InitFormation()
        {
            foreach (Formation formation in Formation.AVAILABLES)
            {
                _formations.Items.Add(formation);
            }

            _formations.SelectedIndex = 0;
        }


        private void numControl_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown numControl)
            {
                if (numControl.ParentForm is FrmDemandeurEmploi form)
                {
                    int currentYear = int.Parse(
                        DateTime.Now.ToString("yyyy")
                    );

                    Size iconSize = SystemInformation.SmallIconSize;
                    Bitmap bitmap = new Bitmap(iconSize.Width, iconSize.Height);

                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(SystemIcons.Exclamation.ToBitmap(), new Rectangle(Point.Empty, iconSize));
                    }

                    Icon smallerErrorIcon = Icon.FromHandle(bitmap.GetHicon());

                    //System.Drawing.Icon myIcon = new Icon(SystemIcons.Exclamation, 4, 4);

                    if (numControl.Value > currentYear)
                    {
                        numControl.Value = currentYear;
                        form.yearRegisterInfo.Image = smallerErrorIcon.ToBitmap();
                    }
                    else if (numControl.Value < currentYear - JobSeeker.MAX_YEAR_FROM_NOW)
                    {
                        numControl.Value = currentYear - JobSeeker.MAX_YEAR_FROM_NOW;
                        form.yearRegisterInfo.Image = smallerErrorIcon.ToBitmap();
                    }
                    else
                    {
                        form.yearRegisterInfo.Image = null;
                    }
                }

            }
        }
    }
}
