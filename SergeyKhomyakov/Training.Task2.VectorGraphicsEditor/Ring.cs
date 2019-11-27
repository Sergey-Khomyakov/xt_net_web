using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Ring : IFigures
    {
        private int _X;
        private int _Y;
        private double _ExternalR;
        private double _InteriorR;

        public void GetСoordinates()
        {
            string coordinate_X = string.Empty;
            string coordinate_Y = string.Empty;
            string radius_ExternalR = string.Empty;
            string radius_InteriorR = string.Empty;

            Console.Write("Введите координаты центра кольца Х = ");
            coordinate_X = Console.ReadLine();
            while (!int.TryParse(coordinate_X, out _X))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Х = ");
                coordinate_X = Console.ReadLine();
            }

            Console.Write("Введите координаты центра кольца Y = ");
            coordinate_Y = Console.ReadLine();
            while (!int.TryParse(coordinate_Y, out _Y))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("Y = ");
                coordinate_Y = Console.ReadLine();
            }

            Console.Write("Введите радиус внешнего круга R = ");
            radius_ExternalR = Console.ReadLine();
            while (!double.TryParse(radius_ExternalR, out _ExternalR))
            {
                Console.WriteLine("Ошибка !!");
                Console.Write("R = ");
                radius_ExternalR = Console.ReadLine();
            }

            Console.Write("Введите радиус внутреннего круга R = ");
            radius_InteriorR = Console.ReadLine();
            while (!double.TryParse(radius_InteriorR, out _InteriorR) || _ExternalR < _InteriorR && _InteriorR != 0)
            {
                if (_InteriorR > _ExternalR)
                {
                    Console.WriteLine("Внутренний круг больше внешнего !!!");
                }
                else
                {
                    Console.WriteLine("Ошибка !!");
                }
                
                Console.Write("R = ");
                radius_InteriorR = Console.ReadLine();
            }
        }

        private double Square { get { return Math.PI * (Math.Pow(_ExternalR, 2) - Math.Pow(_InteriorR, 2)); } }

        public void ShowFigures()
        {
            Console.WriteLine("\nВы создали фигуру !!");
            Console.WriteLine($"Тип Фигуры: 'Кольцо' с координатами центр ({_X},{_Y})\nВнешним радиусом {_ExternalR}\nВнутренним радиусом {_InteriorR}\nПлощадь кольца {Square:#.##}\n");
        }
    }
}
