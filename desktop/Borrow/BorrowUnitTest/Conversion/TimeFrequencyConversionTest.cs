using BorrowCore;
using BorrowCore.Convertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowUnitTest.Conversion
{
    [TestClass]
    public class TimeFrequencyConversionTest
    {
        [TestMethod]
        public void TestAllAllowedConversion()
        {
            foreach (
                Tuple<TimeFrequency, string> allowedConversion in TimeFrequencyConversion.CORRESPONDENCE)
            {
                Assert.AreEqual(
                    allowedConversion.Item1,
                    TimeFrequencyConversion.Convert(allowedConversion.Item2)
                );

                Assert.AreEqual(
                    allowedConversion.Item2,
                    TimeFrequencyConversion.Convert(allowedConversion.Item1)
                );
            }
        }

        [TestMethod]
        public void TestUnknownValues()
        {
            try
            {
                TimeFrequencyConversion.Convert("Un test");
                TimeFrequencyConversion.Convert(String.Empty);

                Assert.IsTrue(false);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
