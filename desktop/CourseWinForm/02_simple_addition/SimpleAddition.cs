using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_simple_addition
{
    internal class SimpleAddition
    {
        private const char OPERATOR_PLUS = '+';
        private const string OPERATOR_EQUAL = " = ";

        private int ResultAddition { get; set; }
        private StringBuilder ResultPrintRaw { get; set; }

        public SimpleAddition()
        {
            this.Reset();
            this.ResultPrintRaw = new StringBuilder();
        }

        public void Add(int number)
        {
            this.ResultAddition += number;
            this.ResultPrintRaw.Append(number);
            this.ResultPrintRaw.Append(OPERATOR_PLUS);
        }

        public void Calculate()
        {
            this.ResultPrintRaw.Append(OPERATOR_EQUAL);
            this.ResultPrintRaw.Append(ResultAddition);
            this.ResultPrintRaw.Append(OPERATOR_PLUS);
        }

        public void Reset()
        {
            this.ResultAddition = 0;
            this.ResultPrintRaw = new StringBuilder();
        }

        public string PrintableResult()
        {
            return this.ResultPrintRaw.ToString();
        }
    }
}
