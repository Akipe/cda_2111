using BorrowCore.Convertion;
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
            foreach(var frequencyAllowed in TimeFrequencyConversion.CORRESPONDENCE)
            {
                Assert.IsTrue(
                    TimeFrequencyValidation.IsValid(frequencyAllowed.Item2)
                );

                Assert.IsTrue(
                    TimeFrequencyValidation.IsValid(frequencyAllowed.Item2.ToUpper())
                );

                Assert.IsTrue(
                    TimeFrequencyValidation.IsValid(frequencyAllowed.Item2.ToLower())
                );

                Assert.IsTrue(
                    TimeFrequencyValidation.IsValid(" " + frequencyAllowed.Item2 + " ")
                );
            }
        }

        [TestMethod]
        public void TestRandomValues()
        {
            Assert.IsFalse(
                TimeFrequencyValidation.IsValid(
                    GeneralValidation.GetRandomString(25)
                )
            );
        }

        [TestMethod]
        public void TestEmptyValues()
        {
            Assert.IsFalse(
                TimeFrequencyValidation.IsValid("")
                );
            Assert.IsFalse(
                TimeFrequencyValidation.IsValid(" ")
                );
            Assert.IsFalse(
                TimeFrequencyValidation.IsValid(String.Empty)
                );
            Assert.IsFalse(
                TimeFrequencyValidation.IsValid(System.Environment.NewLine)
                );
            Assert.IsFalse(
                TimeFrequencyValidation.IsValid('\t'.ToString())
                );
        }
    }
}
