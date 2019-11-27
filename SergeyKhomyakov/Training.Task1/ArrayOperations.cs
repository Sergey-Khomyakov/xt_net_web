using System;

namespace Training.Task1
{
    class ArrayOperations
    {

        /// <summary>
        /// 1.7. Метот выводит максимальное и минимальное значения в массиве, сортирует массив и выводит полученный результат.
        /// </summary>
        /// <param name="arraySize">Размер массива</param>
        public void ShowArray(int arraySize)
        {
            if (arraySize == 0)
            {
                Console.WriteLine("Массив равен 0");
            }
            else 
            {
               int[] array = new int[arraySize];
                FillArray(array);
                Console.Write("Изначальный массив: ");
                ViewArray(array);
                Console.WriteLine($"Максимальное значение в массиве {MaxValueInArray(array)}");
                Console.WriteLine($"Минимальное значение в массиве {MinValueInArray(array)}");
                SortArray(array);
                Console.Write("Отсортированный массив: ");
                ViewArray(array);
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

        /// <summary>
        /// 1.8. Метод заменяет все положительные элементы в трёхмерном массиве на нули и выводит полученный результат
        /// </summary>
        /// <param name="arraySize">Размер массива</param>
        public void ShowNoPositiveNumbersInArray(int arraySize)
        {
            if (arraySize == 0) 
            {
                Console.WriteLine("Массив равен 0");
            }
            else 
            {
                int[,,] array = new int[arraySize, arraySize, arraySize];
                FillArray(array);
                Console.WriteLine("Изначальный массив");
                ViewArray(array);
                ChangingPositiveElementsInArray(array);
                Console.WriteLine("Изменённый массив");
                ViewArray(array);
            }

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

        /// <summary>
        /// 1.9. Метод определяет сумму неотрицательных элементов в одномерном массиве
        /// </summary>
        /// <param name="arraySize">Размер массива</param>
        public void ShowSumOfNonNegativeElementsInArray(int arraySize) 
        {
            if (arraySize == 0)
            {
                Console.WriteLine("Массив равен 0");
            }
            else
            {
                int[] array = new int[arraySize];
                int sum = 0;
                FillArray(array);
                Console.Write("Массив: ");
                ViewArray(array);

                for (int i = 0; i < arraySize; i++)
                {
                    if (array[i] > 0)
                    {
                        sum += array[i];
                    }
                }
                Console.WriteLine($"Сумму неотрицательных элементов  = {sum}");
            }
        }

        /// <summary>
        /// 1.10. Метод выводит сумму элементов массива, стоящих на чётных позициях
        /// </summary>
        /// <param name="arraySize">Размер массива</param>
        public void ShowSumEvenPositionsInArray(int arraySize) 
        {
            if (arraySize == 0)
            {
                Console.WriteLine("Массив равен 0");
            }
            else
            {
                int[,] array = new int[arraySize, arraySize];
                FillArray(array);
                ViewArray(array);
                Console.WriteLine($"Сумма стоящих на чётных позициях = {SumEvenPositions(array)}");
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
