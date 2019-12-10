using System;

namespace Training.Task4
{
    internal static class Helper
    {
        /// <summary>
        /// Task 4.4 Method gets the sum of the array
        /// </summary>
        public static int GetSumArray(this int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        /// <summary>
        /// Task 4.5  Method checks string for positive numbers
        /// </summary>
        public static bool IsCheckPositiveNumber(this string str) 
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("String Empty or null");
            }
            else 
            {
                foreach (char c in str)
                {
                    if (char.IsNumber(c) && str[0] != '-') 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
