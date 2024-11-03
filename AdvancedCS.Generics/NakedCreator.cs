namespace AdvancedCS.Generics
{
    public class NakedCreator : IVehicleCreator<Bike>
    {
        public Bike Create(double engine)
        {
            return new Bike("Naked bike", engine);
        }
    }
}
