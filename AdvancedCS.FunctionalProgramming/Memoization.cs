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

                Console.WriteLine($"Cacheando {number} por primera vez");
                double total = Math.Pow(number, pow);
                cache[number] = total;

                return total;
            };
        }

        public static Func<int, Task<string>> GetUrl(string url)
        {
            var cache = new Dictionary<int, string>();

            return async (id) =>
            {
                if (cache.ContainsKey(id))
                {
                    Console.WriteLine($"Ya existe el id: {id}");
                    return cache[id];
                }

                Console.WriteLine($"Cacheando el id: {id} por primera vez");

                using (var client = new HttpClient())
                {
                    var requestURL = url + "/" + id;
                    var response = await client.GetAsync(requestURL);
                    var responseBody = await response.Content.ReadAsStringAsync();

                    cache[id] = responseBody;

                    return responseBody;
                }
            };
        }

        public static Func<TInput, TOutput> Mem<TInput, TOutput>(Func<TInput, TOutput> func)
        {
            var cache = new Dictionary<TInput, TOutput>();

            return (key) =>
            {
                if (cache.ContainsKey(key))
                {
                    Console.WriteLine($"Cacheado: {key}");
                    return cache[key];
                }

                Console.WriteLine($"Cacheando por primera vez: {key}");
                TOutput value = func(key);
                cache[key] = value;

                return value;
            };
        }

        public static Func<TInput, Task<TOutput>> MemAsync<TInput, TOutput>(Func<TInput, Task<TOutput>> func)
        {
            var cache = new Dictionary<TInput, TOutput>();

            return async (key) =>
            {
                if (cache.ContainsKey(key))
                {
                    Console.WriteLine($"Cacheado: {key}");
                    return cache[key];
                }

                Console.WriteLine($"Cacheando por primera vez: {key}");
                TOutput value = await func(key);
                cache[key] = value;

                return value;
            };
        }

    }
}
