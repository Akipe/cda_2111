using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public class CapitalBorrowValidation : DataValidation
    {
        // Est ce que le champ capital emprunté respecte les contraintes
        // - que des chiffres
        // - maximum 10 chiffres
        // - pas de decimal
        // - obligatoire
        public override bool IsValid(string capitalBorrow)
        {
            _regexControl = new Regex(@"^\d{1,10}$");

            return _regexControl.IsMatch(capitalBorrow);
        }
    }
}
