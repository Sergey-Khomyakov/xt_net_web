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

        private new double Square { get { return Math.PI * (Math.Pow(R, 2) - Math.Pow(_interiorR, 2)); } }

        public new void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Кольцо' с координатами центр ({point.X},{point.Y})\nВнешним радиусом {R}\nВнутренним радиусом {_interiorR}\nПлощадь кольца {Square:#.##}\n");
        }
    }
}
