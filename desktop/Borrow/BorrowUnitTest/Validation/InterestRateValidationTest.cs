using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class InterestRateValidationTest
    {
        [TestMethod]
        public void TestRange()
        {
            foreach(int interestAllowed in InterestRateValidation.ALLOWED)
            {
                Assert.IsTrue(
                    InterestRateValidation.IsValid(
                        interestAllowed.ToString()
                    )
                );
            }

            int numberToLow = InterestRateValidation.ALLOWED[0] - 1;

            Assert.IsFalse(
                InterestRateValidation.IsValid(
                    numberToLow.ToString()  
                )
            );

            int numberToHigh = InterestRateValidation
                .ALLOWED[InterestRateValidation.ALLOWED.Length - 1] + 1;

            Assert.IsFalse(
                InterestRateValidation.IsValid(
                    numberToHigh.ToString()
                )
            );
        }

        [TestMethod]
        public void TestEmpty()
        {
            Assert.IsFalse(InterestRateValidation.IsValid(""));
            Assert.IsFalse(InterestRateValidation.IsValid(String.Empty));
        }
    }
}
