namespace CompositionExpressionCore
{
    public abstract class Expression
    {
        public abstract int Evaluate();
        public abstract string Format(bool showResult = true);
        public abstract string Format2();
        public abstract string Operation();
        public abstract string Format3();
    }
}