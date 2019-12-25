using System;

namespace Training.Task2.VectorGraphicsEditor
{
    internal class Ring : Circle, IFigures
    {
        protected double _interiorR;

        public Ring(Point point, double r, double InteriorR) : base(point, r)
        {
            _interiorR = InteriorR;
        }

        public double InteriorR
        {

            get { return _interiorR; }

            set
            {
                if (value < R && value > 0)
                {
                    _interiorR = value;
                }
                else
                {
                    throw new ArgumentException("Inner radius cannot be greater than outer !!!");
                }
            }
        }
        public new void ShowFigures()
        {
            Console.WriteLine("\nYou created a shape !!");
            Console.WriteLine($"Shape Type: 'Ring' with center coordinates ({point.X},{point.Y})\nOuter radius {R}\nInner radius {_interiorR}\nRing area {Square:#.##}\n");
        }
        private new double Square { get { return Math.PI * (Math.Pow(R, 2) - Math.Pow(_interiorR, 2)); } }
    }
}
