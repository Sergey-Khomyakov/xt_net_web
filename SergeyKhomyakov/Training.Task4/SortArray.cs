using System;

namespace Training.Task4
{   
    public delegate void MethodContainer();
    class SortArray
    {  
        public event MethodContainer onSort;

        /// <summary>
        ///  Task 4.1
        /// </summary>
        public void Sort<T>(T[] array, Func<T,T,int> func) 
        {
            if (func == null)
            {
                throw new NullReferenceException();
            }
            else 
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (func(array[j + 1], array[j]) < 0)
                        {
                            var temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                onSort?.Invoke();
            }
        }
    }
}
