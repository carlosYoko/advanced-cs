namespace AdvancedCS.FunctionalProgramming
{
    public class MaybeFunctor<T> : IFunctor<T>
    {
        private readonly T _value;
        private readonly bool _hasValue;

        public MaybeFunctor(T value, bool hasValue)
        {
            this._value = value;
            this._hasValue = hasValue;
        }

        public static MaybeFunctor<T> Some(T value) => new MaybeFunctor<T>(value, true);

        public static MaybeFunctor<T> None() => new MaybeFunctor<T>(default(T), false);

        public IFunctor<TResult> MyMap<TResult>(Func<T, TResult> fn)
        {
            if (!_hasValue)
            {
                return MaybeFunctor<TResult>.None();
            }
            return MaybeFunctor<TResult>.Some(fn(_value));
        }

        public T GetValue() => _hasValue ? _value : default(T);
    }
}
