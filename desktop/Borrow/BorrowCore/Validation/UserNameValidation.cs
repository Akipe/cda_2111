using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public static class UserNameValidation
    {
        // Est ce que le champ nom respecte les contraintes
        // - il est optionnel
        // - uniquement des caractères alphabétiques, avec le tiret
        public static bool IsValid(string userName)
        {
            Regex regexRule = new Regex(
                @"^([a-zA-ZÀ-ÿ]+((-)?[a-zA-ZÀ-ÿ]+)*)*$"
            );

            return regexRule.IsMatch(userName);
        }
    }
}
