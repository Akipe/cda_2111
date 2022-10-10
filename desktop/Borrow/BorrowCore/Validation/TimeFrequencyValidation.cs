using BorrowCore.Convertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public static class TimeFrequencyValidation
    {
        // Est ce que la périodicité du remboursement est valide
        // - doit être :
        //      * Mensuelle
        //      * Bimestrielle
        //      * Trimestrielle
        //      * Semestrielle
        //      * Annuelle
        public static bool IsValid(string frequency)
        {
            foreach (var frequencyAllowed in TimeFrequencyConversion.CORRESPONDENCE)
            {
                if (String.Equals(frequencyAllowed.Item2.ToLower(), frequency.Trim().ToLower()))
                    return true;
            }

            return false;
        }
    }
}
