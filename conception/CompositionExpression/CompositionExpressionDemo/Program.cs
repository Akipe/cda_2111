// See https://aka.ms/new-console-template for more information

using CompositionExpressionCore;
using CompositionExpressionCore.Expressions;
using CompositionExpressionCore.Expressions.Binaries;

Expression exp1 = new Addition(new Number(2), new Number(3));
Expression exp2 = new Addition(new Number(89), exp1);
Expression exp3 = new Substraction(exp2, exp1);
Expression exp4 = new Substraction(exp3, new Number(14));
Expression exp5 = new Addition(new Substraction(new Number(16), new Number(19)), new Substraction(new Number(20), new Number(27)));

Console.WriteLine(new Number(1).Format() + '\n');
Console.WriteLine(exp1.Format() + '\n');
Console.WriteLine(exp2.Format() + '\n');
Console.WriteLine(exp3.Format() + '\n');
Console.WriteLine(exp4.Format() + '\n');
Console.WriteLine(exp5.Format() + '\n');

Console.WriteLine(new Number(1).Format() + '\n');
Console.WriteLine(exp1.Format2() + '\n');
Console.WriteLine(exp2.Format2() + '\n');
Console.WriteLine(exp3.Format2() + '\n');
Console.WriteLine(exp4.Format2() + '\n');
Console.WriteLine(exp5.Format2() + '\n');

Expression cyrilExp1 = new Substraction(new Number(2), new Number(3));
Console.WriteLine(cyrilExp1);

Expression cyrilExp2 = new Substraction(new Number(89), cyrilExp1);
Console.WriteLine(cyrilExp2.Format2());

Expression toto = new Addition(new Addition(new Number(2), new Number(5)), new Number(3));
Console.WriteLine(toto.Format3());