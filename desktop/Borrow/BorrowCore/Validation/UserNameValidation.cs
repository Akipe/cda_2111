using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public class UserNameValidation : DataValidation
    {
        // Est ce que le champ nom respecte les contraintes
        // - il est optionnel
        // - uniquement des caractères alphabétiques, avec le tiret
        public override bool IsValid(string userName)
        {
            _regexControl = new Regex(
                @"^([a-zA-ZÀ-ÿ]+((-)?[a-zA-ZÀ-ÿ]+)*)*$"
            );

            return _regexControl.IsMatch(userName);
        }
    }
}
