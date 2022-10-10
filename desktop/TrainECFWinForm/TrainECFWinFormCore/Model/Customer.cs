using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainECFWinFormCore.Model
{
    public class Customer
    {
        public readonly string firstName;
        public readonly string lastName;

        public Customer(
            string firstName,
            string lastName
        )
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
