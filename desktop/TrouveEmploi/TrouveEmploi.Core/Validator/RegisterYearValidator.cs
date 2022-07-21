using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrouveEmploi.Core.Persons;

namespace TrouveEmploi.Core.Validator
{
    public static class RegisterYearValidator
    {
        public static bool IsValid(int year)
        {
            return
                CommonsValidator.IsYearNotInFuture(year) &&
                CommonsValidator.IsYearNotTooOld(year, JobSeeker.MAX_YEAR_FROM_NOW)
            ;
        }
    }
}
