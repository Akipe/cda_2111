using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class UserNameValidationTest
    {
        [TestMethod]
        public void TestUserNameOptionnal()
        {
            Assert.IsTrue(
                UserNameValidation.IsValid(string.Empty),
                "The name can be empty"
            );
        }

        [TestMethod]
        public void TestUserNameAlphabeticChar()
        {
            Assert.IsTrue(
                UserNameValidation.IsValid("Toto")
            );
            Assert.IsTrue(
                UserNameValidation.IsValid("Eric")
            );
        }

        [TestMethod]
        public void TestUserNameDigit()
        {
            Assert.IsFalse(
                UserNameValidation.IsValid("1234"),
                "The name doesn't allow numbers"
            );
        }

        [TestMethod]
        public void TestUserNameDash()
        {
            Assert.IsTrue(
                UserNameValidation.IsValid("Jean-Gérome"),
                "It doesn't allow dash"
            );

            Assert.IsTrue(
                UserNameValidation.IsValid("Jean-Louis-Macet"),
                "It doesn't allow dash"
            );

            Assert.IsFalse(
                UserNameValidation.IsValid("Jean--"),
                "The name doesn't allow multiple dash 'Jean--'"
            );
            Assert.IsFalse(
                UserNameValidation.IsValid("--")
            );
            Assert.IsFalse(
                UserNameValidation.IsValid("--jean")
            );
            Assert.IsFalse(
                UserNameValidation.IsValid("-")
            );
            Assert.IsFalse(
                UserNameValidation.IsValid("Jean-")
            );
            Assert.IsFalse(
                UserNameValidation.IsValid("-jean")
            );
        }
    }
}
