using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainECFWinFormCore.Model;

namespace TrainECFWinFormTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestCreation()
        {
            Customer customer = new Customer("Toto", "Tata");

            Assert.AreEqual("Toto", customer.firstName);
            Assert.AreEqual("Tata", customer.lastName);
        }
    }
}
