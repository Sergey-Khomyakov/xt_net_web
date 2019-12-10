using System;
using System.Threading;

namespace Training.Task4
{
    class Program
    {        
        public static int EqualsString(string first, string second)
        {
            if (Equals(first, second)) return 0;
            if (Equals(first, null)) return -1;
            if (Equals(second, null)) return 1;

            if (first.Length == second.Length)
            {
                return first.CompareTo(second);
            }
            else 
            {
                return first.Length.CompareTo(second.Length);
            }       
        }
        /// <summary>
        /// Task 4.2
        /// </summary>
        public static void CustomSortDemo() 
        {
            string[] array = new string[] { "Bbbbbb","dans", "cats", "a", "be","dadad", "zaza" };
            SortArray array1 = new SortArray();
            Handler handler = new Handler();
            array1.onSort += handler.Message;
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            array1.Sort<string>(array, EqualsString);           
            Console.WriteLine("===============");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            array1.onSort -= handler.Message;
        }

       /// <summary>
       /// Task 4.3 
       /// </summary>
        private static void SortingUnit() 
        {          
            Console.Write("[");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|");
                Thread.Sleep(500);
            }
            Console.Write("]");
            Console.WriteLine();
            CustomSortDemo();
        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(SortingUnit);
            Console.WriteLine("Начата сортировка массива, пожалуйста подождите..");
            Console.WriteLine();
            th1.Start();
            string str = "-12";           
            Console.WriteLine(str.IsCheckPositiveNumber());
            Console.ReadKey();
        }
    }
}
