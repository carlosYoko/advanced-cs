namespace AdvancedCS.Generics
{
    public class Clock
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
        }

        public Clock()
        {
            _date = DateTime.Now;
        }
    }
}

