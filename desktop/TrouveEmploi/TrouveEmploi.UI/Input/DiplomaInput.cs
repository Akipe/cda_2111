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
    internal class DiplomaInput : JobSeekerInput
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
            if (!String.IsNullOrWhiteSpace(_name.Text))
            {
                jobSeeker.SetDiploma(
                    new Diploma(_name.Text.Trim()),
                    (int)_year.Value
                );
            }
        }

        public bool IsValid()
        {
            bool isAllValid = true;

            if (DiplomaValidator.IsNameValid(_name.Text))
            {
                SetControlValid(_name);
            }
            else
            {
                SetControlInvalid(_name);
                isAllValid = false;
            }

            if (DiplomaValidator.IsYearValid((int)_year.Value))
            {
                SetControlValid(_year);
            }
            else
            {
                SetControlInvalid(_year);
                isAllValid = false;
            }

            return isAllValid;
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

            _year.Minimum = decimal.MinValue;
            _year.Maximum = decimal.MaxValue;
            /*_year.Minimum = currentYear - JobSeeker.MAX_YEAR_FROM_NOW;
            _year.Maximum = currentYear;*/

            _year.Value = currentYear;

            _year.ValueChanged += new EventHandler(numControl_ValueChanged);
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
                        form.diplomayearInfo.Image = smallerErrorIcon.ToBitmap();
                    }
                    else if (numControl.Value < currentYear - JobSeeker.MAX_YEAR_FROM_NOW)
                    {
                        numControl.Value = currentYear - JobSeeker.MAX_YEAR_FROM_NOW;
                        form.diplomayearInfo.Image = smallerErrorIcon.ToBitmap();

                    }
                    else
                    {
                        form.diplomayearInfo.Image = null;
                    }
                }
            }
        }
    }
}
