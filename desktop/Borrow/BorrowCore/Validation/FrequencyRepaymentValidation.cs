using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public static class FrequencyRepaymentValidation
    {
        public static readonly string[] ALLOWED = new string[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"
        };

        // Est ce que la périodicité du remboursement est valide
        // - doit être :
        //      * Mensuelle
        //      * Bimestrielle
        //      * Trimestrielle
        //      * Semestrielle
        //      * Annuelle
        public static bool IsValid(string frequency)
        {
            foreach (string frequencyAllowed in ALLOWED)
            {
                if (String.Equals(frequencyAllowed.ToLower(), frequency.Trim().ToLower()))
                    return true;
            }

            return false;
        }
    }
}
