using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationTraining.Validation
{
    internal static class CommonValidation
    {
        public static bool DoesExceedCharLimit(string sentence, int min, int max)
        {
            return sentence.Length >= min && sentence.Length <= max;
        }

        public static bool IsAlpha(string sentence)
        {
            return new Regex(@"^[\w]*$")
                .IsMatch(sentence);
        }
    }
}
