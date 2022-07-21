using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.UI.Core.Validator
{
    public static class RegisterYearValidator
    {
        public static bool IsValid(int year)
        {
            var a = CommonsValidator.IsYearNotInFuture(year);
            var b = CommonsValidator.IsYearNotTooOld(year, 60);

            return
                CommonsValidator.IsYearNotInFuture(year) &&
                CommonsValidator.IsYearNotTooOld(year, 60)
            ;
        }
    }
}
