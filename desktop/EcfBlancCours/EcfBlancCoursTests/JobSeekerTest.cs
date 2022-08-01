using EcfBlancCoursCore;

namespace EcfBlancCoursTests
{
    [TestClass]
    public class JobSeekerTest
    {
        [TestMethod]
        public void Test_ID()
        {
            JobSeeker j1 = new JobSeeker();
            JobSeeker j2 = new JobSeeker();

            Assert.AreEqual(1, j1.Id);
            Assert.AreEqual(2, j2.Id);
        }

        [TestMethod]
        public void Test_copy()
        {
            JobSeeker j1 = new JobSeeker();
            j1.FirstName = "Toto";
            j1.LastName = "Tata";

            JobSeeker j2 = new JobSeeker(j1);

            Assert.AreEqual(j1.FirstName, j2.FirstName);
            Assert.AreEqual(j1.LastName, j2.LastName);
            Assert.AreEqual(j1.RegistrationYear, j2.RegistrationYear);
            Assert.AreEqual(j1.Level, j2.Level);
            Assert.AreEqual(j1.LastDiplomaName, j2.LastDiplomaName);
            Assert.AreEqual(j1.LastDiplomaYear, j2.LastDiplomaYear);
            Assert.AreEqual(j1.Id, j2.Id);
        }
    }
}