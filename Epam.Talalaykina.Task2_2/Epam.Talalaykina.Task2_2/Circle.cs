namespace Epam.Talalaykina.Task2_2
{
    public class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

        public Circle(double x, double y, double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }
        /*private double _x;
        private double _y;
        private double _r;

        public Circle(double x, double y, double r)
        {
            _x = x;
            _y = y;
            _r = r;
        }

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        
        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }*/
    }
}