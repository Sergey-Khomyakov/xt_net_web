using System;
using System.Linq;

namespace Training.Task4
{
    class ISeekYou
    {
        /// <summary>
        /// Get the maximum element in the array
        /// </summary>
        public int GetMax(int[] array) 
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) 
                {
                    max = array[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Get maximum element in array using delegate
        /// </summary>
        public int GetMaxDelegate(int[] array, Func<int,int,bool> equalsDelegate) 
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (equalsDelegate(max, array[i]))
                {
                    max = array[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Get maximum element in array using Linq
        /// </summary>
        public int GetMaxLinq(int[] array) => array.Max();
        public bool EqualsInt(int i, int j) => i < j;
    }
}
