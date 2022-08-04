using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainECFWinFormCore.Model
{
    public class Booking
    {
        public readonly Customer customer;
        public readonly double price;
        public readonly DateTime start;
        public readonly DateTime end;

        public int nbNight
        {
            get
            {
                TimeSpan diff = end - start;

                return diff.Days + 1;
            }
        }

        public double pricePerDay
        {
            get
            {
                return price / nbNight;
            }
        }

        public Booking(
            Customer customer,
            double price,
            DateTime start,
            DateTime end
        )
        {
            this.customer = customer;
            this.price = price;
            this.start = start;
            this.end = end;
        }
    }
}
