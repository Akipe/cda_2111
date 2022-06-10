using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class FrequencyRepaymentValidationTest
    {
        [TestMethod]
        public void TestAllowedValues()
        {
            foreach(string frequencyAllowed in FrequencyRepaymentValidation.ALLOWED)
            {
                Assert.IsTrue(
                    FrequencyRepaymentValidation.IsValid(frequencyAllowed)
                );

                Assert.IsTrue(
                    FrequencyRepaymentValidation.IsValid(frequencyAllowed.ToUpper())
                );

                Assert.IsTrue(
                    FrequencyRepaymentValidation.IsValid(frequencyAllowed.ToLower())
                );

                Assert.IsTrue(
                    FrequencyRepaymentValidation.IsValid(" " + frequencyAllowed + " ")
                );
            }
        }

        [TestMethod]
        public void TestRandomValues()
        {
            Assert.IsFalse(
                FrequencyRepaymentValidation.IsValid(
                    GeneralValidation.GetRandomString(25)
                )
            );
        }

        [TestMethod]
        public void TestEmptyValues()
        {
            Assert.IsFalse(
                FrequencyRepaymentValidation.IsValid("")
                );
            Assert.IsFalse(
                FrequencyRepaymentValidation.IsValid(" ")
                );
            Assert.IsFalse(
                FrequencyRepaymentValidation.IsValid(String.Empty)
                );
            Assert.IsFalse(
                FrequencyRepaymentValidation.IsValid(System.Environment.NewLine)
                );
            Assert.IsFalse(
                FrequencyRepaymentValidation.IsValid('\t'.ToString())
                );
        }
    }
}
