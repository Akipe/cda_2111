using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core.Education
{
    public class Diploma
    {
        public static List<Diploma> Register = new List<Diploma>
        {
            new Diploma("CDA"),
            new Diploma("DWWM"),
            new Diploma("TSSR"),
            new Diploma("AIS")
        };


        public readonly string name;

        public Diploma(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
