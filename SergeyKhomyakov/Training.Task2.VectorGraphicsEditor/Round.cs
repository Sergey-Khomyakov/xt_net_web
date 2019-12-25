using System;

namespace Training.Task2.VectorGraphicsEditor
{
    internal class Round : Circle, IFigures
    {
        public Round(Point Point, double r) : base(Point, r){}

        public new void ShowFigures()
        {
            Console.WriteLine("\nYou created a shape !!");
            Console.WriteLine($"Shape Type: 'Circle' with center coordinates ({point.X},{point.Y}) radius = {R}\nArea of ​​a circle = {Square:#.##}\n");
        }
    }
}