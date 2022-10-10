using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public static class CapitalBorrowValidation
    {
        // Est ce que le champ capital emprunté respecte les contraintes
        // - que des chiffres
        // - maximum 10 chiffres
        // - pas de decimal
        // - obligatoire
        public static bool IsValid(string capitalBorrow)
        {
            Regex regexRule = new Regex(@"^\d{1,10}$");

            return regexRule.IsMatch(capitalBorrow);
        }
    }
}
