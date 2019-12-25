using System;

namespace Training.Task1
{
    class NumberOperations
    {
        /// <summary>
        /// Task 1.1. Show rectangle area
        /// </summary>
        /// <param name=”width”>Rectangle width</param>
        /// <param name=”height”>Rectangle height</param>
        public void ShowAreaOfRectangel(int width, int height) 
        {
            Console.WriteLine($"Rectangle area with sides {width} and {height} = {width * height}");
        }
        /// <summary>
        /// Task 1.5. Get the sum of all numbers that are multiples of 3 or 5
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
