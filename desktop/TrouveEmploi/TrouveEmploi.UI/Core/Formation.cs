using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core
{
    public class Formation
    {
        public readonly string name;

        public Formation(string name, int rateEmployementPercent)
        {
            this.name = name;
            RateEmployement = (double)rateEmployementPercent / 100d;
        }

        public double RateEmployement
        {
            get; set;
        }
    }
}
