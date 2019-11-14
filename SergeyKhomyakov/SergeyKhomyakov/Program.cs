using System;

namespace Task0_Intro
{
    class Program
    {
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
        }

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
        static void Main(string[] args)
        {
            string getNumber = string.Empty;
            int number;

            Console.Write("Введите положительное число: ");
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

                Console.Write("Введите положительное число: ");
                getNumber = Console.ReadLine();
                Console.WriteLine();
            }

            Sequence(number);
            Console.WriteLine();
            Simple(number);

            Console.ReadKey();
        }
    }
}
