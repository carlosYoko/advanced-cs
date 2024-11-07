namespace AdvancedCS.FunctionalProgramming
{
    public static class ListExtensions
    {
        public static List<TOutput> MyMap<TInput, TOutput>(this List<TInput> lst, Func<TInput, TOutput> fn)
        {
            List<TOutput> lstResult = new List<TOutput>();

            foreach (TInput item in lst)
            {
                TOutput output = fn(item);
                lstResult.Add(output);
            }

            return lstResult;
        }
    }
}
