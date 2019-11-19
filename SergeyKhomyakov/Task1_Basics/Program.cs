using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_Basics
{
    class Program
    {
        private static string GetAreaOfRectangel(int width, int heigth) => $"Площадь прямоугольника со сторонами {width} и {heigth} = {width * heigth}";

        private static void GetSlide(int number)
        {
            for (int i = 0; i < number + 1; i++)
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

        private static void GetTriangle(int number)
        {

            for (int i = 0; i < number + 1; i++) // построение строк 
            {
                for (int j = number; j != 0; j--) // построение левой части  
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
                for (int j = 0; j != number; j++) // построение правой части 
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

        private static void GetChristmasTree(int number) 
        {
            for (int d = 0; d <= number; d++) // построение количество треугольников 
            {
                for (int i = 0; i <= d; i++) // построение строк 
                {

                    for (int j = number; j != 0; j--) // построение левой части  
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
                    for (int j = 0; j != number + 1; j++) // построение правой части 
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

        private static void SumOfNumbers(int number) 
        {
            int sum = 0;
            Console.Write("Натуральные числа: ");
            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    Console.Write(i + " ");
                }
            }
            Console.Write("их сумма = " + sum);
        }

        private static void GetFontAdjustment()
        {
            List<string> listFont = new List<string>();
            int number = 0;
            var stringNumber = string.Empty;
            Console.WriteLine($"Параметры надписи: None");
            while (true)
            {
                Console.WriteLine("Введите:");
                Console.WriteLine($"\t 1: Bold");
                Console.WriteLine($"\t 2: Italic");
                Console.WriteLine($"\t 3: Underline");
                stringNumber = Console.ReadLine();
                while (!int.TryParse(stringNumber, out number) || number > 3) // Проверка ввода 
                {
                    Console.WriteLine("Введите существующее число !");
                    stringNumber = Console.ReadLine();
                } 
                if (number == 0)
                {
                    break;
                }
                else 
                {
                    switch (number)
                    {
                        case 1:
                            {
                                if (listFont.Count(x => x == "Bold") >= 1)
                                {
                                    listFont.Remove("Bold");
                                }
                                else
                                {
                                    listFont.Add("Bold");
                                }

                                break;
                            }
                        case 2:
                            {
                                if (listFont.Count(x => x == "Italic") >= 1)
                                {
                                    listFont.Remove("Italic");
                                }
                                else
                                {
                                    listFont.Add("Italic");
                                }

                                break;
                            }
                        case 3:
                            {
                                if (listFont.Count(x => x == "Underline") >= 1)
                                {
                                    listFont.Remove("Underline");
                                }
                                else
                                {
                                    listFont.Add("Underline");
                                }

                                break;
                            }
                    }
                    Console.Write($"Параметры надписи: ");
                    foreach (var list in listFont)
                    {
                        Console.Write(list + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Если хотите выйти из программы введите число 0");
                    number = 0;
                }
                
            }
        }

        private static void Array(int number)
        {
            int[] array = new int[number];
            FillArray(array);
            Console.Write("Изначальный массив: ");
            ViewArray(array);
            Console.WriteLine($"Максимальное значение в массиве {MaxValueInArray(array)}");
            Console.WriteLine($"Минимальное значение в массиве {MinValueInArray(array)}");
            SortArray(array);
            Console.Write("Отсортированный массив: ");
            ViewArray(array);
        }

        private static void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
        }

        private static int MinValueInArray(int[] array)
        {
            int minValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        private static int MaxValueInArray(int[] array)
        {
            int maxValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        private static void SortArray(int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        number = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = number;
                    }
                }
            }
        }

        private static void ViewArray(int[] array)
        {
            Console.Write("{ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 == array.Length)
                {
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.Write(array[i] + ",");
                }
            }
            Console.Write("}");
            Console.WriteLine();
        }

        private static int NumberInputСheck()
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

            Console.WriteLine(GetAreaOfRectangel(width, heigth));
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

            Console.WriteLine("Введите число");
            Number = NumberInputСheck();
            SumOfNumbers(Number);
            Console.WriteLine();

            GetFontAdjustment();
            Console.WriteLine();

            Console.WriteLine("Введите число");
            Number = NumberInputСheck();
            Array(Number);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
