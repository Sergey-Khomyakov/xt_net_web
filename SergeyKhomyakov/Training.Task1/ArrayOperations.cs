using System;

namespace Training.Task1
{
    class ArrayOperations
    {

        /// <summary>
        /// 1.7. Show maximum and minimum values ​​in the array, sorts the array
        /// </summary>
        /// <param name="arraySize">Size array</param>
        public void ShowArray(int arraySize)
        {
            if (arraySize == 0)
            {
                Console.WriteLine("The array is 0");
            }
            else 
            {
               int[] array = new int[arraySize];
                FillArray(array);
                Console.Write("The original array: ");
                ViewArray(array);
                Console.WriteLine($"The maximum value in the array {MaxValueInArray(array)}");
                Console.WriteLine($"The minimum value in the array {MinValueInArray(array)}");
                SortArray(array);
                Console.Write("Sorted array: ");
                ViewArray(array);
            }
        }

        /// <summary>
        /// 1.8. Show all positive elements in a three-dimensional array to zeros
        /// </summary>
        /// <param name="arraySize">Size array</param>
        public void ShowNoPositiveNumbersInArray(int arraySize)
        {
            if (arraySize == 0) 
            {
                Console.WriteLine("The array is 0");
            }
            else 
            {
                int[,,] array = new int[arraySize, arraySize, arraySize];
                FillArray(array);
                Console.WriteLine("Original array");
                ViewArray(array);
                ChangingPositiveElementsInArray(array);
                Console.WriteLine("Modified array");
                ViewArray(array);
            }
        }

        /// <summary>
        /// 1.9. Show sum of non-negative elements in a one-dimensional array
        /// </summary>
        /// <param name="arraySize">Size array</param>
        public void ShowSumOfNonNegativeElementsInArray(int arraySize) 
        {
            if (arraySize == 0)
            {
                Console.WriteLine("The array is 0");
            }
            else
            {
                int[] array = new int[arraySize];
                int sum = 0;
                FillArray(array);
                Console.Write("Array: ");
                ViewArray(array);

                for (int i = 0; i < arraySize; i++)
                {
                    if (array[i] > 0)
                    {
                        sum += array[i];
                    }
                }
                Console.WriteLine($"Sum of non-negative elements  = {sum}");
            }
        }

        /// <summary>
        /// 1.10. Show the sum of array elements in even positions
        /// </summary>
        /// <param name="arraySize">Size array</param>
        public void ShowSumEvenPositionsInArray(int arraySize) 
        {
            if (arraySize == 0)
            {
                Console.WriteLine("The array is 0");
            }
            else
            {
                int[,] array = new int[arraySize, arraySize];
                FillArray(array);
                ViewArray(array);
                Console.WriteLine($"The amount of standing in even positions = {SumEvenPositions(array)}");
            }
        }
        private void FillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
        }

        private int MinValueInArray(int[] array)
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

        private int MaxValueInArray(int[] array)
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
        private void SortArray(int[] array)
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

        private void ViewArray(int[] array)
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

        private void FillArray(int[,,] array)
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

        private void ChangingPositiveElementsInArray(int[,,] array)
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

        private void ViewArray(int[,,] array)
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

        private void FillArray(int[,]array) 
        {
            Random random = new Random();
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    array[k, i] = random.Next(0, 100);
                }
            }
        }

        private void ViewArray(int[,]array) 
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    Console.Write(array[k, i] + " ");
                }
                Console.WriteLine();
            }
        }
        private int SumEvenPositions(int[,]array) 
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if ((k + i) % 2 == 0)
                    {
                        sum += array[k, i];
                    }
                }
            }
            return sum;
        }
    }
}
