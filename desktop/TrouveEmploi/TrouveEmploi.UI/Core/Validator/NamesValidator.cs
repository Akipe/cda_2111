using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core.Validator
{
    public static class NamesValidator
    {
        public static bool IsValid(string name)
        {
            var a = CommonsValidator.HasSizeBetween(name, 1, 30);
            var b = CommonsValidator.IsOnlyWord(name);

            return
                CommonsValidator.HasSizeBetween(name, 1, 30) &&
                CommonsValidator.IsOnlyWord(name);
        }
    }
}
