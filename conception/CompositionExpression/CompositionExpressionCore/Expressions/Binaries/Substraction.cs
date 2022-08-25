using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExpressionCore.Expressions.Binaries
{
    public class Substraction : Binary
    {
        public Substraction(Expression op1, Expression op2) : base(op1, op2)
        {
        }

        public override int Evaluate()
        {
            return _op1.Evaluate() - _op2.Evaluate();
        }

        public override string Format(bool showResult = true)
        {
            StringBuilder format = new StringBuilder();

            format.Append(_op1.Format(false));
            format.Append('-');
            format.Append(_op2.Format(false));

            if (showResult)
            {
                format.Append('=');
                format.Append(Evaluate());
            }

            return format.ToString();
        }

        public override string Format2()
        {
            return Operation() + "=" + Evaluate().ToString();
        }

        public override string Operation()
        {
            StringBuilder format = new StringBuilder();

            if (_op1 is Binary)
            {
                format.Append("(");
                format.Append(_op1.Operation());
                format.Append(")");
            }
            else
            {
                format.Append(_op1.Operation());
            }

            format.Append('-');

            if (_op2 is Binary)
            {
                format.Append("(");
                format.Append(_op2.Operation());
                format.Append(")");
            }
            else
            {
                format.Append(_op2.Operation());
            }

            return format.ToString();
        }

        public override string ToString()
        {
            return Evaluate().ToString();
        }

        public override string Format3()
        {

            StringBuilder format = new StringBuilder();

            int resultOp1 = _op1.Evaluate();
            int numberDigit = resultOp1.ToString().Length;

            if (numberDigit == _op1.Format3().Length)
            {
                format.Append(_op1.Format3());
            }
            else
            {
                format.Append(_op1.Format3().Substring(0, _op1.Format3().Length - numberDigit - 1));
            }
            format.Append('-');
            if (numberDigit == _op2.Format3().Length)
            {
                format.Append(_op2.Format3());
            }
            else
            {
                format.Append(_op2.Format3().Substring(0, _op2.Format3().Length - numberDigit - 1));
            }

            format.Append('=');
            format.Append(Evaluate());

            return format.ToString();
        }
    }
}
