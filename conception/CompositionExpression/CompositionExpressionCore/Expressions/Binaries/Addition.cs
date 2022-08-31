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

        public override string RepresentationOperation()
        {
            StringBuilder format = new StringBuilder();

            format.Append(_op1.RepresentationOperation());
            format.Append('+');
            format.Append(_op2.RepresentationOperation());

            return format.ToString();
        }

        public override string ToString()
        {
            return Evaluate().ToString();
        }
    }
}
