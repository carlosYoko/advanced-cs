namespace AdvancedCS.FunctionalProgramming
{
    public class MaybeMonad<T>
    {
        private readonly T _value;
        private readonly bool _hasValue;

        public MaybeMonad(T value, bool hasvalue)
        {
            _value = value;
            _hasValue = hasvalue;
        }

        public static MaybeMonad<T> Some(T value) => new MaybeMonad<T>(value, true);

        public static MaybeMonad<T> None() => new MaybeMonad<T>(default(T), false);

        public T GetValue() => _hasValue ? _value : default(T);

        public override string ToString()
        {
            return _hasValue ? $"Some: {_value}" : "None";
        }

        public MaybeMonad<TResult> Bind<TResult>(Func<T, MaybeMonad<TResult>> binder)
        {
            if (!_hasValue)
            {
                return MaybeMonad<TResult>.None();
            }

            return binder(_value);
        }

    }
}
