using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.Core.Validator
{
    public static class CommonsValidator
    {
        public static bool HasSizeBetween(string sentence, int min, int max)
        {
            return sentence.Length >= min && sentence.Length <= max;
        }

        public static bool IsOnlyWord(string word)
        {
            Regex wordWithDash = new Regex(@"^([\w]*)+((-)([\w]+))*$");
            Regex hasDigit = new Regex(@"\d");
            return 
                wordWithDash.IsMatch(word) &&
                !hasDigit.IsMatch(word) &&
                !String.IsNullOrWhiteSpace(word);
        }

        public static bool IsWordsWithSpace(string sentence)
        {
            Regex wordWithDashAndSpace = new Regex(@"^((([\w]*)+((-)([\w]+))*((')([\w]+))*)(\s)?)+$");
            return
                wordWithDashAndSpace.IsMatch(sentence) &&
                !String.IsNullOrWhiteSpace(sentence);
        }

        public static bool IsYearNotInFuture(int year)
        {
            return year <= int.Parse(DateTime.Now.ToString("yyyy"));
        }

        public static bool IsYearNotTooOld(int year, int howManyFromNow)
        {
            var a = int.Parse(DateTime.Now.ToString("yyyy")) - howManyFromNow;

            return year >= (
                int.Parse(DateTime.Now.ToString("yyyy")) - howManyFromNow
            );
        }
    }
}
