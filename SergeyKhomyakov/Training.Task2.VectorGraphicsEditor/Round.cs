using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Round : IFigures
    {
        private int _X;
        private int _Y;
        private double _R;
        public void GetСoordinates()
        {
            string coordinate_X = string.Empty;
            string coordinate_Y = string.Empty;
            string radius_R = string.Empty;

            Console.Write("Введите координаты центра круга Х = ");
            coordinate_X = Console.ReadLine();
            while (!int.TryParse(coordinate_X, out _X))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Х = ");
                coordinate_X = Console.ReadLine();
            }

            Console.Write("Введите координаты центра круга Y = ");
            coordinate_Y = Console.ReadLine();
            while (!int.TryParse(coordinate_Y, out _Y))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Y = ");
                coordinate_Y = Console.ReadLine();
            }

            Console.Write("Введите радиус круга R = ");
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

        public void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Круг' с координатами центра ({_X},{_Y}) радиус = {_R}\nПлощадь круга = {Square:#.##}\n");
        }
    }
}
