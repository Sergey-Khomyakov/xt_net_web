using System;

namespace Task0_Intro
{
    class Program
    {
        /// <summary>
        /// Task_0.1
        /// </summary>
        /// <param name="getNumber"></param>
        static void Sequence(int getNumber) 
        {
            for (int i = 1; i < getNumber + 1; i++) 
            {
                if (i == getNumber)
                {
                    Console.Write(i);
                }
                else 
                {
                    Console.Write($"{i},");
                }               
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Task_0.2
        /// </summary>
        /// <param name="getNumber"></param>
        static void Simple(int getNumber) 
        {
            bool simpleNumber = true;

            for (int i = 2; i < getNumber / 2; i++) 
            {
                if (getNumber % i == 0) 
                {
                    simpleNumber = false;
                    break;
                }
            }

            if (simpleNumber)
            {
                Console.WriteLine($"Число {getNumber} простое");
            }
            else 
            {
                Console.WriteLine($"Число {getNumber} не простое");
            }
        }
        /// <summary>
        /// Task_0.3
        /// </summary>
        /// <param name="getNumber"></param>
        static void Square(int getNumber) 
        {
            for (int i = 0; i < getNumber; i++) 
            {
                for (int j = 0; j < getNumber; j++) 
                {
                    if (getNumber / 2 == i && getNumber / 2 == j)
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

        static bool ParityCheck(int getNumber) 
        {
            return (getNumber % 2) == 0;
        }
        static int NumberCheck() 
        {           
            string getNumber = string.Empty;
            int number;
            
            getNumber = Console.ReadLine();

            while (!int.TryParse(getNumber, out number) || number < 0)
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
                getNumber = Console.ReadLine();
                Console.WriteLine();
            }
            return number;
        }
        /// <summary>
        /// Task_0.4(0.5)
        /// </summary>
        /// <param name="getNumber"></param>
        static void Array(int getNumber) 
        {
            Random random = new Random();
            int[,] array = new int[getNumber, getNumber];
            for (int i = 0; i < getNumber; i++) 
            {
                for (int j = 0; j < getNumber; j++) 
                {
                    array[i, j] = random.Next(0, 100);
                }
            }
            ViewArray(array);
            SortArray(array);
            Console.WriteLine();
            ViewArray(array);
        }
        static void SortArray(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int h = i; h < array.GetLength(0); h++)
                    {
                        for (int m = (h == i) ? j : 0; m < array.GetLength(1); m++)
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
            int number;

            Console.Write("Введите положительное число: ");
            number = NumberCheck();
            Sequence(number);
            Console.WriteLine();

            Console.Write("Введите число: ");
            number = NumberCheck();
            Simple(number);
            Console.WriteLine();

            Console.Write("Введите нечётное число: ");
            number = NumberCheck();
            while (ParityCheck(number)) 
            {
                Console.WriteLine("Вы ввели чётное число ");
                Console.WriteLine();
                Console.Write("Введите нечётное число: ");
                number = NumberCheck();
            }
            Console.WriteLine();

            Square(number);
            Console.WriteLine();
            Console.Write("Введите размерность массива: ");
            number = NumberCheck();
            Console.WriteLine();
            Array(number);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
