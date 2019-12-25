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
                Console.WriteLine($"Number {number} simple");
            }
            else 
            {
                Console.WriteLine($"Number {number} not prime");
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
                    Console.WriteLine("You entered a negative number");
                }
                else 
                {
                    Console.WriteLine("I do not understand what you entered :(((");               
                }
                Console.WriteLine();

                Console.Write("Insert the number: ");
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
            for (int i = 0; i < array.GetLength(0); i++) // line listing
            {
                for (int j = 0; j < array.GetLength(1); j++) // column listing
                {
                    for (int h = i; h < array.GetLength(0); h++) // enumeration of lines to check
                    {
                        for (int m = (h == i) ? j : 0; m < array.GetLength(1); m++) // enumeration of columns for verification (exclude checked and replaced characters)
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

            Console.Write("Enter a positive number: ");
            number = NumberInputСheck();            
            Console.WriteLine(ReturnSequenceOfNumbers(number));

            Console.Write("Insert the number: ");
            number = NumberInputСheck();
            CheckOfSimpleNumber(number);
            Console.WriteLine();

            Console.Write("Enter an odd number: ");
            number = NumberInputСheck();
            while (ParityCheck(number)) 
            {
                Console.WriteLine("You entered an even number ");
                Console.WriteLine();
                Console.Write("Enter an odd number: ");
                number = NumberInputСheck();
            }
            Console.WriteLine();

            GetSquare(number);
            Console.WriteLine();
            Console.Write("Enter the dimension of the array: ");
            number = NumberInputСheck();
            Console.WriteLine();
            Array(number);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
