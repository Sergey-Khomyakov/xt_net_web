using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Rectangle : Line, IFigures
    {
        protected Point point3;
        protected Point point4;
        public Rectangle(Point point1 ,Point point2 ,Point point3 , Point point4): base(point1, point2) 
        {
            this.point3 = point3;
            this.point4 = point4;
            if (point3 == point4)
            {
                throw new ArgumentException("Points have the same coordinates !!! ");
            }
        }
        public new void ShowFigures()
        {
            Console.WriteLine("\nYou created a shape !!");
            Console.WriteLine($"Shape Type: Rectangle'\n" +
                $"First point coordinates ({point1.X},{point1.Y})\n" +
                $"The coordinates of the second point ({point2.X},{point2.Y})\n" + 
                $"Third Point Coordinates ({point3.X},{point3.Y})\n" + 
                $"Fourth Point Coordinates ({point4.X},{point4.Y})\n" +
                $"Height = {Height:#.##} Width = {Width:#.##} Area = {Height * Width:#.##}\n");
        }

        private double Height
        {
            get
            {
                return Math.Sqrt((Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2)));
            }
        }
        private double Width
        {
            get
            {
                return Math.Sqrt((Math.Pow((point2.X - point3.X), 2) + Math.Pow((point2.Y - point3.Y), 2)));
            }
        }
    }
}
