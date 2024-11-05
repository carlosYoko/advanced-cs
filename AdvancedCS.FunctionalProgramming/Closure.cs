﻿namespace AdvancedCS.FunctionalProgramming
{
    public static class Closure
    {
        public static Func<int, int, int> SumClosure()
        {
            int i = 0;

            return (a, b) =>
                {
                    i++;
                    Console.WriteLine(i);
                    return a + b;
                };
        }

        public static Action DelayExecuter(int time, Action fn)
        {
            return () =>
            {
                Console.WriteLine("Antes del delay");

                Thread.Sleep(time);
                fn();
                Console.WriteLine("Despues del delay");
            };
        }
    }
}
