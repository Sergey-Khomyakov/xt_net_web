using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Сircle : IFigures
    {
        private int _X;
        private int _Y;
        private double _R;
        public void GetСoordinates()
        {
            string coordinate_X = string.Empty;
            string coordinate_Y = string.Empty;
            string radius_R = string.Empty;

            Console.Write("Введите координаты центра окружности Х = ");
            coordinate_X = Console.ReadLine();
            while (!int.TryParse(coordinate_X, out _X))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Х = ");
                coordinate_X = Console.ReadLine();
            }

            Console.Write("Введите координаты центра окружности Y = ");
            coordinate_Y = Console.ReadLine();
            while (!int.TryParse(coordinate_Y, out _Y))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Y = ");
                coordinate_Y = Console.ReadLine();
            }

            Console.Write("Введите радиус окружности R = ");
            radius_R = Console.ReadLine();
            while (!double.TryParse(radius_R, out _R))
            {
                if (_R < 0)
                {
                    Console.WriteLine("Радиус отрицательный !! Ошибка");
                }
                else
                {
                    Console.WriteLine("Ошибка !!");
                }
                Console.Write("R = ");
                radius_R = Console.ReadLine();
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
            Console.WriteLine($"Тип Фигуры: 'Окружность' с координатами центра ({_X},{_Y}) радиус = {_R}\nПлощадь окружности = {Square:#.##}\nДлина окружности = {Length:#.##}\n");
        }
    }
}
