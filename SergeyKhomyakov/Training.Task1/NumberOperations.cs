using System;

namespace Training.Task1
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
        public int GetSumOfNumbersMultiplesOf(int number, int[] ArrayNumber)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                foreach (var item in ArrayNumber) 
                {
                    if (i % item == 0)
                    {
                        sum += i;                   
                    }
                }
            }
            return sum;
        }
    }
}
