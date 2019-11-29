using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Circle : IFigures
    {
        private Point point;
        private double _R;

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

        private double Square
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
        public void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Окружность' с координатами центра ({point.X},{point.Y}) радиус = {_R}\nПлощадь окружности = {Square:#.##}\nДлина окружности = {Length:#.##}\n");
        }
    }
}
