namespace AdvancedCS.Generics
{
    public class Bike : Vehicle, IInfo
    {
        private string _brand;

        public string Brand
        {
            get
            {
                return _brand;
            }
        }

        public Bike(string brand, double engine) : base(engine)
        {
            _brand = brand;
        }

        public string GetInfo()
        {
            return $"{Brand} - {Engine}cc";
        }
    }
}
