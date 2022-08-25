﻿using System;
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
            return _op1.Operation() + "-" + _op2.Operation() + "=" + Evaluate().ToString();
        }

        public override string Operation()
        {
            StringBuilder format = new StringBuilder();

            format.Append(_op1.Operation());
            format.Append('-');
            format.Append(_op2.Operation());

            return format.ToString();
        }

        public override string ToString()
        {
            return Evaluate().ToString();
        }
    }
}
