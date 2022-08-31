namespace CompositionExpressionCore
{
    public abstract class Expression
    {
        public abstract int Evaluate();
        public abstract string Format();
        public abstract string RepresentationOperation();
    }
}