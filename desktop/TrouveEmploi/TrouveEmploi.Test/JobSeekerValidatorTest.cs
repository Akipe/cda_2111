using TrouveEmploi.Core.Persons;
using TrouveEmploi.Core.Validator;

namespace TrouveEmploi.Test
{
    [TestClass]
    public class JobSeekerValidatorTest
    {
        [TestMethod]
        public void TestDiplomaYearNow()
        {
            int year = int.Parse(DateTime.Now.ToString("yyyy"));

            Assert.IsTrue(DiplomaValidator.IsYearValid(year));
        }

        [TestMethod]
        public void TestDiplomaYearFuture()
        {
            int future = int.Parse(DateTime.Now.AddYears(1).ToString("yyyy"));

            Assert.IsFalse(DiplomaValidator.IsYearValid(future));
        }

        [TestMethod]
        public void TestDiplomaLimitPast()
        {
            int limitPast = int.Parse(DateTime.Now.ToString("yyyy")) - JobSeeker.MAX_YEAR_FROM_NOW;

            Assert.IsTrue(DiplomaValidator.IsYearValid(limitPast));
        }

        [TestMethod]
        public void TestDiplomaTooPast()
        {
            int tooPast = int.Parse(DateTime.Now.ToString("yyyy")) - JobSeeker.MAX_YEAR_FROM_NOW - 1;

            Assert.IsFalse(DiplomaValidator.IsYearValid(tooPast));
        }

        [TestMethod]
        public void TestCorrectNames()
        {
            string name = "Ervé-Louis";

            Assert.IsTrue(NamesValidator.IsValid(name));
        }

        [TestMethod]
        public void TestIncorrectNames()
        {
            string name = "Ervé-Louis-";

            Assert.IsFalse(NamesValidator.IsValid(name));
        }
    }
}