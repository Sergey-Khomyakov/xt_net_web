using System;
using System.Text;

namespace Training.Task0
{
    class Program
    {
        static string ReturnSequenceOfNumbers(int number) 
        {
            var stringNumbers = new StringBuilder();

            for (int i = 1; i < number; i++) 
            {
                stringNumbers.Append(i + ",");            
            }
            stringNumbers.Append(number);
            return stringNumbers.ToString();
        }

        static void CheckOfSimpleNumber(int number) 
        {
            bool isFlagSimpleNumber = true;

            if (number % 2 == 0)
            {
                isFlagSimpleNumber = false;
            }
            else 
            {
                for (int i = 2; i < number / 2; i++) 
                {
                    if (number % i == 0) 
                    {
                        isFlagSimpleNumber = false;
                        break;
                    }
                }
            }

            if (isFlagSimpleNumber)
            {
                Console.WriteLine($"Число {number} простое");
            }
            else 
            {
                Console.WriteLine($"Число {number} непростое");
            }
        }

        static void GetSquare(int number) 
        {
            for (int i = 0; i < number; i++) 
            {
                for (int j = 0; j < number; j++) 
                {
                    if (number / 2 == i && number / 2 == j)
                    {
                        Console.Write(" ");
                    }
                    else 
                    {
                        Console.Write("*");
                    }                       
                }
                Console.WriteLine();
            }
        }

        static bool ParityCheck(int number) 
        {
            return (number % 2) == 0;
        }
        static int NumberInputСheck() 
        {           
            var stringNumber = string.Empty;
            int number = 0;

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

        static void Array(int number) 
        {
            int[,] array = new int[number, number];
            FillArray(array);
            ViewArray(array);
            SortArray(array);
            Console.WriteLine();
            ViewArray(array);
        }

        static void FillArray(int[,] array) 
        {          
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    array[i, j] = random.Next(0, 100);
                }
            }
        }

        static void SortArray(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++) // перечисление строк
            {
                for (int j = 0; j < array.GetLength(1); j++) // перечисление столбцов 
                {
                    for (int h = i; h < array.GetLength(0); h++) // перечисление строк для проверки 
                    {
                        for (int m = (h == i) ? j : 0; m < array.GetLength(1); m++) // перечисление столбцов для проверки (исключаем проверенные и заменннеые символы)
                        {
                            if (array[i, j] > array[h, m])
                            {
                                int t = array[i, j];
                                array[i, j] = array[h, m];
                                array[h, m] = t;
                            }
                        }
                    }
                }
            }
        }

        static void ViewArray(int[,] array) 
        {
            for(int i = 0; i < array.GetLength(0); i++) 
            {
                Console.Write("{ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j + 1 == array.GetLength(1))
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    else 
                    {
                        Console.Write(array[i,j] + ",");     
                    }             
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int number = 0;

            Console.Write("Введите положительное число: ");
            number = NumberInputСheck();            
            Console.WriteLine(ReturnSequenceOfNumbers(number));

            Console.Write("Введите число: ");
            number = NumberInputСheck();
            CheckOfSimpleNumber(number);
            Console.WriteLine();

            Console.Write("Введите нечётное число: ");
            number = NumberInputСheck();
            while (ParityCheck(number)) 
            {
                Console.WriteLine("Вы ввели чётное число ");
                Console.WriteLine();
                Console.Write("Введите нечётное число: ");
                number = NumberInputСheck();
            }
            Console.WriteLine();

            GetSquare(number);
            Console.WriteLine();
            Console.Write("Введите размерность массива: ");
            number = NumberInputСheck();
            Console.WriteLine();
            Array(number);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
