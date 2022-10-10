using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public static class InterestRateValidation
    {
        public static readonly int[] ALLOWED = new int[]
        {
            7,
            8,
            9
        };

        // Est ce que le taux d'intérêt est valide
        // - c'est un nombre
        // - il est obligatoire
        // - peut être 7%, 8%, ou 9%
        public static bool IsValid(string interestRateInPercent)
        {
            int interestRate;

            if (!Int32.TryParse(interestRateInPercent, out interestRate))
                return false;

            return ALLOWED.Contains(interestRate);
        }
    }
}
