using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExpressionCore.Expressions
{
    public class Number : Expression
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public override int Evaluate()
        {
            return _value;
        }

        public override string Format(bool showResult = true)
        {
            return ToString();
        }

        public override string Format2()
        {
            return ToString();
        }

        public override string Format3()
        {
            return ToString();
        }

        public override string Operation()
        {
            return ToString();
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
