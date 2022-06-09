using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class CapitalBorrowValidationTest : DataValidationTest
    {
        public CapitalBorrowValidationTest()
            : base(new CapitalBorrowValidation())
        {}

        [TestMethod]
        public void TestZeroNumber()
        {
            Assert.IsTrue(Validator.IsValid("0"));
        }

        [TestMethod]
        public void TestRangeNumber()
        {
            Assert.IsTrue(Validator.IsValid("1"));
            Assert.IsTrue(Validator.IsValid("0123456789"));
            Assert.IsFalse(Validator.IsValid("-1"));
            Assert.IsFalse(Validator.IsValid("01234567899"));
        }

        [TestMethod]
        public void TestInvalidCharacteres()
        {
            Assert.IsFalse(Validator.IsValid("azerty"));
            Assert.IsFalse(Validator.IsValid("é"));
            Assert.IsFalse(Validator.IsValid("@"));
        }

        [TestMethod]
        public void TestInvalidEmpty()
        {
            Assert.IsFalse(Validator.IsValid(""));
            Assert.IsFalse(Validator.IsValid(" "));
            Assert.IsFalse(Validator.IsValid(String.Empty));
            Assert.IsFalse(Validator.IsValid(System.Environment.NewLine));
            Assert.IsFalse(Validator.IsValid('\t'.ToString()));
        }
    }
}
