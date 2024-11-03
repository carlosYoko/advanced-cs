namespace AdvancedCS.Generics
{
    public interface IVehicleCreator<out T>
    {
        T Create(double engine);
    }
}
