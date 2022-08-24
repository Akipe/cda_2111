using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExpressionCore.Expressions
{
    public abstract class Binary : Expression
    {
        protected Expression _op1;
        protected Expression _op2;

        public Binary(Expression op1, Expression op2)
        {
            _op1 = op1;
            _op2 = op2;
        }
    }
}
