namespace AdvancedCS.FunctionalProgramming
{
    public static class Functions
    {
        public static string PipeStrings(string input, params Func<string, string>[] functions)
        {
            var result = input;

            foreach (var func in functions)
            {
                result = func(result);
            }

            return result;
        }

        public static T PipeGenerics<T>(T input, params Func<T, T>[] functions)
        {
            var result = input;

            foreach (var func in functions)
            {
                result = func(result);
            }

            return result;
        }
    }
}
