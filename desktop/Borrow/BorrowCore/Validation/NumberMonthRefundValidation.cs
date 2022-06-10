using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    // Est ce que la durée en mois du remboursement est valide
    // - un nombre obligatoire
    // - minimum à 1 et maximum à 360 mois
    public static class NumberMonthRefundValidation
    {
        public const int MIN = 1;
        public const int MAX = 360;

        public static bool IsValid(string data)
        {
            int numberMonths;

            if (!Int32.TryParse(data, out numberMonths))
                return false;

            return numberMonths >= MIN && numberMonths <= MAX;
        }
    }
}
