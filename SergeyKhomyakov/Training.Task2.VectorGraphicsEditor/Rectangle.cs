using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Rectangle : Line, IFigures
    {
        private Point point1;
        private Point point2;
        private Point point3;
        private Point point4;

        public Rectangle(Point point1 ,Point point2 ,Point point3 , Point point4): base(point1,point2) 
        {
            this.point3 = point3;
            this.point4 = point4;
        }

        private double Height
        {
            get
            {
                return Math.Sqrt((Math.Pow((point1.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2)));
            }
        }
        private double Width
        {
            get
            {
                return Math.Sqrt((Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point2.Y), 2)));
            }
        }
        public new void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Прямоугольник'\n" +
                $"Координаты первой точки ({point1.X},{point1.Y})\n" +
                $"Координаты второй точки ({point2.X},{point2.Y})\n" + 
                $"Координаты третей точки ({point3.X},{point3.Y})\n" + 
                $"Координаты четвертой точки ({point4.X},{point4.Y})\n" +
                $"Высота = {Height} Ширина = {Width} Площадь = {Height * Width:#.##}\n");
        }
    }
}
