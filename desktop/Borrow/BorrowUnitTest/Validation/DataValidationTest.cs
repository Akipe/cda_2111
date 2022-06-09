using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    public abstract class DataValidationTest
    {
        protected DataValidation Validator { get; set; }

        public DataValidationTest(DataValidation validator)
        {
            Validator = validator;
        }
    }
}
