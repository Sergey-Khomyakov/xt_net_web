using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Line : IFigures
    {
        private Point point1;
        private Point point2;

        public Line(Point point1, Point point2) 
        {
            this.point1 = point1;
            this.point2 = point2;
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

            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Линия' координаты первой точки ({point2.X},{point1.Y})\nКоординаты второй точки ({point2.X},{point2.Y})\nДлина прямой = {Length:#.##}\n");
        }
    }
}
