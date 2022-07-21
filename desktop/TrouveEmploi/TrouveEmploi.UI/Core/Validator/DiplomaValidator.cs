using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core.Validator
{
    public static class DiplomaValidator
    {
        public static bool IsYearValid(int year)
        {
            return
                CommonsValidator.IsYearNotInFuture(year) &&
                CommonsValidator.IsYearNotTooOld(year, 60)
            ;
        }

        public static bool IsNameValid(string name)
        {
            return 
                CommonsValidator.HasSizeBetween(name, 3, 40) &&
                CommonsValidator.IsWordsWithSpace(name)
            ;
        }
    }
}
