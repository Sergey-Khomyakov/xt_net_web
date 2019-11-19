using System;

namespace Task1_Basics
{
    class Program
    {
        private static string GetAreaOfRectangel(int width, int heigth) => $"Площадь прямоугольника со сторонами {width} и {heigth} = {width * heigth}";

        private static void GetSlide(int Number)
        {
            for (int i = 0; i < Number + 1; i++)
            {
                for (int j = 0; j != i; j++)
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void GetTriangle(int Number)
        {

            for (int i = 0; i < Number + 1; i++) // построение строк 
            {
                for (int j = Number; j != 0; j--) // построение левой части  
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 0; j != Number; j++) // построение правой части 
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        private static void GetChristmasTree(int Number) 
        {
            for (int d = 0; d <= Number; d++) // построение количество треугольников 
            {
                for (int i = 0; i <= d; i++) // построение строк 
                {

                    for (int j = Number; j != 0; j--) // построение левой части  
                    {
                        if (j <= i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = 0; j != Number + 1; j++) // построение правой части 
                    {
                        if (j <= i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
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
            
            int width, heigth, Number;

            Console.WriteLine("Введите ширину");
            width = NumberInputСheck();
            Console.WriteLine("Введите длину");
            heigth = NumberInputСheck();

            Console.WriteLine(GetAreaOfRectangel(width,heigth));
            Console.WriteLine();

            
            Console.WriteLine("Введите число");
            Number = NumberInputСheck();
            GetSlide(Number);
            Console.WriteLine();

            Console.WriteLine("Введите число");
            Number = NumberInputСheck();
            GetTriangle(Number);
            Console.WriteLine();

            Console.WriteLine("Введите число");
            Number = NumberInputСheck();
            GetChristmasTree(Number);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
