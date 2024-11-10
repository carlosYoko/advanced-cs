namespace AdvancedCS.FunctionalProgramming
{
    public static class Memoization
    {
        public static Func<double, double> MyPow(double pow)
        {
            var cache = new Dictionary<double, double>();

            return (number) =>
            {
                if (cache.ContainsKey(number))
                {
                    Console.WriteLine($"El {number} YA estaba cacheado");
                    return cache[number];
                }

                Console.WriteLine($"El {number} NO estaba cacheado");
                double total = Math.Pow(number, pow);
                cache[number] = total;

                return total;
            };
        }
    }
}
