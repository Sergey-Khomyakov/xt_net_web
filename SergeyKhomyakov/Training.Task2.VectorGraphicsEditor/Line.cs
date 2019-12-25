using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Line : IFigures
    {
        protected Point point1;
        protected Point point2;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
            if (point1 == point2)
            {
                throw new ArgumentException("Points have the same coordinates !!! ");
            }
        }

        private double Length
        {
            get
            {
                return Math.Sqrt((Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2)));
            }
        }
        public void ShowFigures()
        {

            Console.WriteLine("\nYou created a shape !!");
            Console.WriteLine($"Shape Type: 'Line' \nfirst point coordinates ({point1.X},{point1.Y})\nThe coordinates of the second point ({point2.X},{point2.Y})\nStraight length = {Length:#.##}\n");
        }
    }
}
