using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Line : IFigures
    {
        private int _X1;
        private int _Y1;
        private int _X2;
        private int _Y2;

        public void GetСoordinates()
        {
            string coordinate_X1 = string.Empty;
            string coordinate_X2 = string.Empty;
            string coordinate_Y1 = string.Empty;
            string coordinate_Y2 = string.Empty;

            Console.Write("Введите координаты 1 точки Х = ");
            coordinate_X1 = Console.ReadLine();
            while (!int.TryParse(coordinate_X1, out _X1))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Х = ");
                coordinate_X1 = Console.ReadLine();
            }

            Console.Write("Введите координаты 1 точки Y = ");
            coordinate_Y1 = Console.ReadLine();
            while (!int.TryParse(coordinate_Y1, out _Y1))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Y = ");
                coordinate_Y1 = Console.ReadLine();
            }

            Console.Write("Введите координаты 2 точки Х = ");
            coordinate_X2 = Console.ReadLine();
            while (!int.TryParse(coordinate_X2, out _X2))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Х = ");
                coordinate_X2 = Console.ReadLine();
            }

            Console.Write("Введите координаты 2 точки Y = ");
            coordinate_Y2 = Console.ReadLine();
            while (!int.TryParse(coordinate_Y2, out _Y2))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Y = ");
                coordinate_Y2 = Console.ReadLine();
            }

        }
        private double Length
        {
            get
            {
                return Math.Sqrt((Math.Pow((_X2 - _X1), 2) + Math.Pow((_Y2 - _Y1), 2)));
            }
        }
        public void ShowFigures()
        {

            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Линия' координаты первой точки ({_X1},{_Y1})\nКоординаты второй точки ({_X2},{_Y2})\nДлина прямой = {Length:#.##}\n");
        }
    }
}
