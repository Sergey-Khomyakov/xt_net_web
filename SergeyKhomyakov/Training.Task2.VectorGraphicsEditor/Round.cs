using System;

namespace Training.Task2.VectorGraphicsEditor
{
    internal class Round : Circle, IFigures
    {
        public Round(Point Point, double r) : base(Point, r){}

        public new void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Круг' с координатами центра ({point.X},{point.Y}) радиус = {R}\nПлощадь круга = {Square:#.##}\n");
        }
    }
}