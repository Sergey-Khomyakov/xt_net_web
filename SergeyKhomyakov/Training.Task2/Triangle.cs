using System;

namespace Training.Task2
{
    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;
        
        public Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public double A 
        {
            get 
            {
                return _a;
            }
            set
            {
                if (value > 0)
                {
                    _a = value;
                }
                else 
                {
                    throw new ArgumentException("Side of the triangle cannot be negative!!!");
                }
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0)
                {
                    _b = value;
                }
                else
                {
                    throw new ArgumentException("Side of the triangle cannot be negative!!!");
                }
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0)
                {
                    _c = value;
                }
                else
                {
                    throw new ArgumentException("Side of the triangle cannot be negative!!!");
                }
            }
        }
        public void ShowTriangle()
        {
            Console.WriteLine("Side A = {0} B = {1} C = {2}", _a, _b, _c);
            Console.WriteLine("Triangle perimeter = {0:0.##}", GetPerimeter());
            Console.WriteLine("Area of ​​a triangle = {0:0.##}", GetSquare());
        }
        private double GetPerimeter() => _a + _b + _c;

        private double GetSquare() 
        {
                double perimeter = (_a + _b + _c) / 2;
                return Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
        }
    }
}
