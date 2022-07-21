using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Input
{
    internal abstract class JobSeekerInput
    {
        protected void SetControlValid(NumericUpDown num)
        {
            num.Font = new Font(num.Font, FontStyle.Regular);
            num.ForeColor = Color.Blue;
        }

        protected void SetControlInvalid(NumericUpDown num)
        {
            num.Font = new Font(num.Font, FontStyle.Bold);
            num.ForeColor = Color.Red;
        }

        protected void SetControlValid(ComboBox cb)
        {
            cb.Font = new Font(cb.Font, FontStyle.Regular);
            cb.ForeColor = Color.Blue;
        }

        protected void SetControlInvalid(ComboBox cb)
        {
            cb.Font = new Font(cb.Font, FontStyle.Bold);
            cb.ForeColor = Color.Red;
        }

        protected void SetControlValid(TextBox tb)
        {
            tb.Font = new Font(tb.Font, FontStyle.Regular);
            tb.ForeColor = Color.Blue;
        }

        protected void SetControlInvalid(TextBox tb)
        {
            tb.Font = new Font(tb.Font, FontStyle.Bold);
            tb.ForeColor = Color.Red;
        }
    }
}
