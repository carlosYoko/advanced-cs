namespace AdvancedCS.Generics
{
    public class Vehicle
    {
        private double _engine;
        public double Engine
        {
            get
            {
                return _engine;
            }
        }

        public Vehicle(double engine)
        {
            _engine = engine;
        }
    }
}
