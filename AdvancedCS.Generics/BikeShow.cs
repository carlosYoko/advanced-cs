namespace AdvancedCS.Generics
{
    public class BikeShow : IShow<Vehicle>
    {
        public void Show(Vehicle vehicle)
        {
            Console.WriteLine("Engine: " + vehicle.Engine + "cc");
        }
    }
}
