using BorrowCore.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Validation
{
    [TestClass]
    public class NumberMonthRefundValidationTest
    {
        [TestMethod]
        public void TestRange()
        {
            Assert.IsTrue(
                NumberMonthRefundValidation.IsValid(
                    NumberMonthRefundValidation.MIN.ToString()
                )
            );

            Assert.IsTrue(
                NumberMonthRefundValidation.IsValid(
                    NumberMonthRefundValidation.MAX.ToString()
                )
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid(
                    0.ToString()
                )
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid(
                    361.ToString()
                )
            );
        }

        [TestMethod]
        public void TestOnlyNumeric()
        {
            Assert.IsTrue(
                NumberMonthRefundValidation.IsValid(60.ToString())
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid("Une phrase")
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid('a'.ToString())
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid('\n'.ToString())
            );
        }

        [TestMethod]
        public void TestIsMandatory()
        {
            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid(String.Empty)
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid("")
            );

            Assert.IsFalse(
                NumberMonthRefundValidation.IsValid(Environment.NewLine)
            );
        }
    }
}
