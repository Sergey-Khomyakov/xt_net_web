using System;

namespace Training.Task2.VectorGraphicsEditor
{
    internal class Round : Circle, IFigures
    {
        private Point point;
        private double _R;

        public Round(Point Point, double r) : base(Point, r) { }

        private double Square
        {
            get
            {
                return Math.PI * _R * _R;
            }
        }

        public new void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Круг' с координатами центра ({point.X},{point.Y}) радиус = {_R}\nПлощадь круга = {Square:#.##}\n");
        }
    }
}
