namespace AdvancedCS.Generics
{
    public interface IShow<in T>
    {
        public void Show(T element);
    }
}
