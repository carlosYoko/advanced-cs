namespace AdvancedCS.FunctionalProgramming
{
    public class Identity<T> : IFunctor<T>
    {
        private readonly T _value;

        public Identity(T value)
        {
            _value = value;
        }

        public IFunctor<TResult> MyMap<TResult>(Func<T, TResult> fn)
        {
            return new Identity<TResult>(fn(_value));
        }

        public T GetValue()
        {
            return _value;
        }
    }
}