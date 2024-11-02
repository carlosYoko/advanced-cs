namespace AdvancedCS.Generics
{
    public class RandomCustom
    {
        private double _number;

        public double Number
        {
            get { return _number; }
        }

        public RandomCustom()
        {
            _number = new Random().NextDouble();
        }
    }
}
