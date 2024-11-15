namespace AdvancedCS.Concurrent
{
    public static class Methods
    {
        public static async Task Wait(int seconds)
        {
            Console.WriteLine("Comienza la espera");

            await Task.Delay(seconds);

            Console.WriteLine("Fin de la espera");

        }
    }
}
