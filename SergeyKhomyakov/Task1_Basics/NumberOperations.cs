using System;

namespace Task1_Basics
{
    class NumberOperations
    {        
        /// <summary>
        /// Task 1.1. Метод возвращает площадь прямоугольника 
        /// </summary>
        /// <param name=”width”>Ширина прямоугольника</param>
        /// <param name=”height”>Высота прямоугольника</param>
        public string GetAreaOfRectangel(int width, int height) => $"Площадь прямоугольника со сторонами {width} и {height} = {width * height}";

        /// <summary>
        /// Task 1.5. Метод выводит сумму всех чисел кратных 3 или 5
        /// </summary>
        public void GetSumOfNumbersMultiplesOfThreeOrFive(int number)
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
    }
}
