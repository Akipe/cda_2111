using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.Core.Persons;

namespace TrouveEmploi.Core.Validator
{
    public static class DiplomaValidator
    {
        public static bool IsYearValid(int year)
        {
            return
                CommonsValidator.IsYearNotInFuture(year) &&
                CommonsValidator.IsYearNotTooOld(year, JobSeeker.MAX_YEAR_FROM_NOW)
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
