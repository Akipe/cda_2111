using ToutEmbalCorrection.Core;

namespace ToutEmbalCorrection.Test
{
    [TestClass]
    public class ProductionTest
    {
        [TestMethod]
        public void TestType()
        {
            Production p = new Production(
                TypeCaisse.A,
                5000
            );

            Assert.AreEqual(TypeCaisse.A, p.type);
        }

        [TestMethod]
        public void TestDemarrage()
        {
            Production p = new Production(
                TypeCaisse.A,
                5000
            );
            p.Demarrer();

            Assert.AreEqual(5000, p.Quantite);
        }

        [TestMethod]
        public void TestThread()
        {
            Production p = new Production(
                TypeCaisse.A,
                5000
            );
            p.Executer();

            Assert.AreEqual(5000, p.Quantite);
        }
    }
}