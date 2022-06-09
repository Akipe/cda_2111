using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class UserNameValidationTest : DataValidationTest
    {
        public UserNameValidationTest()
            : base(new UserNameValidation())
        {}

        [TestMethod]
        public void TestUserNameOptionnal()
        {
            Assert.IsTrue(
                Validator.IsValid(string.Empty),
                "The name can be empty"
            );
        }

        [TestMethod]
        public void TestUserNameAlphabeticChar()
        {
            Assert.IsTrue(
                Validator.IsValid("Toto")
            );
            Assert.IsTrue(
                Validator.IsValid("Eric")
            );
        }

        [TestMethod]
        public void TestUserNameDigit()
        {
            Assert.IsFalse(
                Validator.IsValid("1234"),
                "The name doesn't allow numbers"
            );
        }

        [TestMethod]
        public void TestUserNameDash()
        {
            Assert.IsTrue(
                Validator.IsValid("Jean-Gérome"),
                "It doesn't allow dash"
            );

            Assert.IsTrue(
                Validator.IsValid("Jean-Louis-Macet"),
                "It doesn't allow dash"
            );

            Assert.IsFalse(
                Validator.IsValid("Jean--"),
                "The name doesn't allow multiple dash 'Jean--'"
            );
            Assert.IsFalse(
                Validator.IsValid("--")
            );
            Assert.IsFalse(
                Validator.IsValid("--jean")
            );
            Assert.IsFalse(
                Validator.IsValid("-")
            );
            Assert.IsFalse(
                Validator.IsValid("Jean-")
            );
            Assert.IsFalse(
                Validator.IsValid("-jean")
            );
        }
    }
}
