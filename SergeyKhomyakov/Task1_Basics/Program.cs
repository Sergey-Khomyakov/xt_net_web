using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_Basics
{
    class Program
    {
        /// <summary>
        /// Task 1.1. Метод возвращает площадь прямоугольника 
        /// </summary>
        /// <param name=”width”>Ширина прямоугольника</param>
        /// <param name=”height”>Высота прямоугольника</param>
        private static string GetAreaOfRectangel(int width, int height) => $"Площадь прямоугольника со сторонами {width} и {height} = {width * height}";

        /// <summary>
        /// Task 1.2. Метод выводит на консоль изображение "Горки"
        /// </summary>
        /// <param name=”number”>Высота горки </param>
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
        /// <summary>
        /// Task 1.3. Метод выводит на консоль изображение "Треугольника"
        /// </summary>
        /// <param name=”number”>Высота треугольника </param>
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
        /// <summary>
        /// Task 1.4. Метод выводит на консоль изображение "Елки"
        /// </summary>
        /// <param name=”number”>Высота елки</param>
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
        /// <summary>
        /// Task 1.5. Метод выводит сумму всех чисел кратных 3 или 5
        /// </summary>
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
        /// <summary>
        /// Task 1.6. Метод позволяет устанавливать и изменять начертание шрифта 
        /// </summary>
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

        /// <summary>
        /// 1.7. Метот заполняет массив, выводит максимальное и минимальное значения в массиве, сортирует массив и выводит полученный результат.
        /// </summary>
        /// <param name="number">Размер массива</param>
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
                array[i] = random.Next(-100, 100);
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

        /// <summary>
        /// 1.8. Метод заменяет все положительные элементы в трёхмерном массиве на нули и выводит полученный результат
        /// </summary>
        /// <param name="number">Размер массива</param>
        private static void ThreeDimensionalArray(int number)
        {
            int[,,] array = new int[number, number, number];
            FillThreeDimensionalArray(array);
            Console.WriteLine("Изначальный массив");
            ViewThreeDimensionalArray(array);
            ChangingPositiveElementsInArray(array);
            Console.WriteLine("Изменённый массив");
            ViewThreeDimensionalArray(array);
        }

        private static void FillThreeDimensionalArray(int[,,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(-10, 10);
                    }
                }
            }
        }

        private static void ChangingPositiveElementsInArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }

        private static void ViewThreeDimensionalArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Массив № {i}");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int g = 0; g < array.GetLength(2); g++)
                    {
                        Console.Write(array[i, j, g]);
                        Console.Write(",");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// 1.9. Метод определяет сумму неотрицательных элементов в одномерном массиве
        /// </summary>
        /// <param name="number">Размер массива</param>
        private static void SumOfNonNegativeElementsInArray(int number) 
        {
            int[] array = new int[number]; 
            int sum = 0;
            FillArray(array);
            Console.Write("Массив: ");
            ViewArray(array);
           
            for (int i = 0; i < number; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Сумму неотрицательных элементов  = {sum}");
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
            int number, numberTask;
            bool isExit = false;
            string[] arrayTask = { "0 - EXIT","1 - RECTANGLE", "2 - TRIANGLE", "3 - ANOTHER TRIANGLE", "4 - X-MAS TREE",
                "5 - SUM OF NUMBERS", "6 - FONT ADJUSTMENT", "7 - ARRAY PROCESSING", "8 - NO POSITIVE", "9 - NON-NEGATIVE SUM", "10 - 2D ARRAY",
                "11 - AVERAGE STRING LENGTH", "12 - CHAR DOUBLER"};
            while(!isExit)
            {
                Console.WriteLine("********************************");
                foreach (var Task in arrayTask) 
                {
                    Console.WriteLine(Task);
                }
                Console.Write("Задание № ");
                numberTask = NumberInputСheck();
                switch (numberTask) 
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:      
                    
                        Console.WriteLine("Введите ширину");
                        int width = NumberInputСheck();
                        Console.WriteLine("Введите длину");
                        int heigth = NumberInputСheck();

                        Console.WriteLine(GetAreaOfRectangel(width, heigth));
                        Console.WriteLine();
                        break;

                    case 2:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        GetSlide(number);
                        Console.WriteLine();
                        break;

                    case 3:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        GetTriangle(number);
                        Console.WriteLine();
                        break;

                    case 4:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        GetChristmasTree(number);
                        Console.WriteLine();
                        break;

                    case 5:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        SumOfNumbers(number);
                        Console.WriteLine();
                        break;

                    case 6:

                        GetFontAdjustment();
                        Console.WriteLine();
                        break;

                    case 7:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        Array(number);
                        Console.WriteLine();
                        break;

                    case 8:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        ThreeDimensionalArray(number);
                        Console.WriteLine();
                        break;

                    case 9:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        SumOfNonNegativeElementsInArray(number);
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
