using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public abstract class DataValidation
    {
        protected Regex _regexControl;

        public abstract bool IsValid(string data);
    }
}
