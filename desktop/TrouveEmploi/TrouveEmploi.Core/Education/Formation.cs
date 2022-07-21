using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.Core.Education
{
    public class Formation
    {
        public static readonly Formation INF_BAC = new Formation("InfBac", 30);
        public static readonly Formation BAC = new Formation("Bac", 40);
        public static readonly Formation BAC_1 = new Formation("Bac+1", 50);
        public static readonly Formation BAC_2 = new Formation("Bac+2", 60);
        public static readonly Formation BAC_3 = new Formation("Bac+3", 70);
        public static readonly Formation BAC_4 = new Formation("Bac+4", 80);
        public static readonly Formation BAC_5 = new Formation("Bac+5", 90);
        public static readonly Formation BAC_SUP_5 = new Formation("SupBac+5", 100);

        public static readonly List<Formation> AVAILABLES = new List<Formation>
        {
            INF_BAC,
            BAC,
            BAC_1,
            BAC_2,
            BAC_3,
            BAC_4,
            BAC_5,
            BAC_SUP_5
        };

        public static Formation Parse(string name)
        {
            foreach (Formation formation in AVAILABLES)
            {
                if (formation.ToString() == name)
                {
                    return formation;
                }
            }

            throw new ArgumentException(
                $"There is no formation named {name}"
            );
        }


        public readonly string name;
        public readonly int rateEmployementPercent;

        public Formation(string name, int rateEmployementPercent)
        {
            this.name = name;
            this.rateEmployementPercent = rateEmployementPercent;
        }

        public double GetRateEmployement()
        {
            return rateEmployementPercent / 100d;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
