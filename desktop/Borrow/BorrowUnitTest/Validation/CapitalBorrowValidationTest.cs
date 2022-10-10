using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class CapitalBorrowValidationTest
    {

        [TestMethod]
        public void TestZeroNumber()
        {
            Assert.IsTrue(
                CapitalBorrowValidation.IsValid("0")
            );
        }

        [TestMethod]
        public void TestRangeNumber()
        {
            Assert.IsTrue(
                CapitalBorrowValidation.IsValid("1")
                );
            Assert.IsTrue(
                CapitalBorrowValidation.IsValid("0123456789")
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid("-1")
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid("01234567899")
                );
        }

        [TestMethod]
        public void TestInvalidCharacteres()
        {
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid("azerty")
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid("é")
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid("@")
                );
        }

        [TestMethod]
        public void TestInvalidEmpty()
        {
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid("")
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid(" ")
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid(String.Empty)
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid(System.Environment.NewLine)
                );
            Assert.IsFalse(
                CapitalBorrowValidation.IsValid('\t'.ToString())
                );
        }
    }
}
