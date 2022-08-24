using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExpressionCore.Expressions.Binaries
{
    public class Addition : Binary
    {
        public Addition(Expression op1, Expression op2): base(op1, op2)
        {
        }

        public override int Evaluate()
        {
            return _op1.Evaluate() + _op2.Evaluate();
        }

        public override string Format(bool showResult = true)
        {
            StringBuilder format = new StringBuilder();

            format.Append(_op1.Format(false));
            format.Append('+');
            format.Append(_op2.Format(false));

            if (showResult)
            {
                format.Append('=');
                format.Append(Evaluate());
            }

            return format.ToString();
        }

        public override string ToString()
        {
            return Evaluate().ToString();
        }
    }
}
