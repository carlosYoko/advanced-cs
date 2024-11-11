namespace AdvancedCS.FunctionalProgramming
{
    public interface IFunctor<T>
    {
        IFunctor<TResult> MyMap<TResult>(Func<T, TResult> fn);

        T GetValue();
    }
}