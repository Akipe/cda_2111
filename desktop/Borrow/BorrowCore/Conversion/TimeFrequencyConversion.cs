using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowCore.Convertion
{
    public static class TimeFrequencyConversion
    {
        public static readonly Tuple<TimeFrequency, string>[] CORRESPONDENCE = {
            new Tuple<TimeFrequency, string>(TimeFrequency.Monthly, "Mensuelle"),
            new Tuple<TimeFrequency, string>(TimeFrequency.BiMonthly, "Bimestrielle"),
            new Tuple<TimeFrequency, string>(TimeFrequency.Quarterly, "Trimestrielle"),
            new Tuple<TimeFrequency, string>(TimeFrequency.SemiAnnual, "Semestrielle"),
            new Tuple<TimeFrequency, string>(TimeFrequency.Annual, "Annuelle")
        };

        public static TimeFrequency Convert(string timeFrequencyWord)
        {
            foreach (var frequencyAllowed in CORRESPONDENCE)
            {
                if (String.Equals(
                    frequencyAllowed.Item2.ToLower(),
                    timeFrequencyWord.Trim().ToLower()))
                {
                    return frequencyAllowed.Item1;
                }
            }

            throw new ArgumentException("Your data to convert has to be present on TimeFrequencyConvertion.CORRESPONDENCE");
        }

        public static string Convert(TimeFrequency timeFrequencyVar)
        {
            foreach (var frequencyAllowed in CORRESPONDENCE)
            {
                if (frequencyAllowed.Item1 == timeFrequencyVar)
                    return frequencyAllowed.Item2;
            }

            throw new ArgumentException("Your TimeFrequency does not exist.");
        }
    }
}
