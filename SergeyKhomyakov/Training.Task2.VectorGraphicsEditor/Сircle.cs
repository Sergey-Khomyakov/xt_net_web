using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Circle : IFigures
    {
        protected Point point;
        protected double _R;

        public Circle(Point point, double r)
        {
            this.point = point;
            this._R = r;
        }

        public double R 
        {
            get 
            {
                return _R;
            }
            set 
            {
                if (value > 0)
                {
                    _R = value;
                }
                else 
                {
                    throw new ArgumentException("Inner radius cannot be greater than outer !!!");
                }
            }
        }
        public void ShowFigures()
        {
            Console.WriteLine("\nYou created a shape!!");
            Console.WriteLine($"Shape Type: 'Circle' with center coordinates ({point.X},{point.Y}) radius = {_R}\nCircle area = {Square:#.##}\nCircumference = {Length:#.##}\n");
        }
        protected double Square
        {
            get
            {
                return Math.PI * _R * _R;
            }
        }
        private double Length
        {
            get
            {
                return 2 * Math.PI * _R;
            }
        }
    }
}
