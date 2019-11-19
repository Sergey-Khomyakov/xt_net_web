using System;

namespace Task1_Basics
{
    class Program
    {
        static void GetRectangel() 
        {
            int width;
            int heigth;
            Console.WriteLine("Введите ширину");
            width = NumberInputСheck();
            Console.WriteLine("Введите длину");
            heigth = NumberInputСheck();

            Console.WriteLine($"Площадь прямоугольника со сторонами {width} и {heigth} = {width * heigth}");
        }
        static int NumberInputСheck()
        {
            var stringNumber = string.Empty;
            int number;

            stringNumber = Console.ReadLine();

            while (!int.TryParse(stringNumber, out number) || number < 0)
            {
                if (number < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число");
                }
                else
                {
                    Console.WriteLine("Я не понимаю что вы ввели :(((");
                }
                Console.WriteLine();

                Console.Write("Введите число: ");
                stringNumber = Console.ReadLine();
                Console.WriteLine();
            }
            return number;
        }
        static void Main(string[] args)
        {
            GetRectangel();
            Console.ReadKey();
        }
    }
}
