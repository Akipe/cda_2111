using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_simple_addition
{
    internal class SimpleAddition
    {
        private int ResultAddition { get; set; }
        public string PrintableResult { get; private set; }

        public SimpleAddition()
        {
            this.Reset();
        }

        public void Add(int number)
        {
            this.ResultAddition += number;
            this.PrintableResult += number + "+";
        }

        public void Calculate()
        {
            this.PrintableResult += " = " + ResultAddition + "+";
        }

        public void Reset()
        {
            this.ResultAddition = 0;
            this.PrintableResult = "";
        }
    }
}
