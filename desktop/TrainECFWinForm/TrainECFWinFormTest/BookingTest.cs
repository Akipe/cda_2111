using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainECFWinFormCore.Model;

namespace TrainECFWinFormTest
{
    [TestClass]
    public class BookingTest
    {
        [TestMethod]
        public void TestCreation()
        {
            DateTime startDate = new DateTime(2022, 10, 14, 16, 45, 0);
            DateTime endDate = new DateTime(2022, 10, 17, 11, 12, 0);

            Customer customer = new Customer("Toto", "Tata");
            Booking book = new Booking(
                customer,
                257.85,
                startDate,
                endDate
            );

            Assert.AreEqual(startDate, book.start);
            Assert.AreEqual(endDate, book.end);
            Assert.AreEqual(257.85, book.price);
            Assert.AreEqual(customer, book.customer);
        }

        [TestMethod]
        public void TestBookDays()
        {
            DateTime startDate = new DateTime(2022, 10, 14, 16, 45, 0);
            DateTime endDate = new DateTime(2022, 10, 17, 11, 12, 0);

            Customer customer = new Customer("Toto", "Tata");
            Booking book = new Booking(
                customer,
                257.85,
                startDate,
                endDate
            );

            Assert.AreEqual(3, book.nbNight);
        }

        [TestMethod]
        public void TestPriceAverage()
        {
            DateTime startDate = new DateTime(2022, 10, 14, 16, 45, 0);
            DateTime endDate = new DateTime(2022, 10, 17, 11, 12, 0);

            Customer customer = new Customer("Toto", "Tata");
            Booking book = new Booking(
                customer,
                257.85,
                startDate,
                endDate
            );

            Assert.AreEqual(257.85 / 3, book.pricePerDay);
        }
    }
}
