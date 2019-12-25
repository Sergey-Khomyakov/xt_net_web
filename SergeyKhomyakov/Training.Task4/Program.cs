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
            Console.WriteLine("\n");
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

        private static int СheckInputNumber()
        {
            var stringNumber = string.Empty;
            int number = 0;

            stringNumber = Console.ReadLine();
            while (!int.TryParse(stringNumber, out number) || number < 0)
            {
                if (number < 0)
                {
                    Console.WriteLine("You entered a negative number");
                }
                else
                {
                    Console.WriteLine("I do not understand what you entered :(((");
                }
                Console.WriteLine();

                Console.Write("Insert the number: ");
                stringNumber = Console.ReadLine();
                Console.WriteLine();
            }
            return number;
        }
        static void Main(string[] args)
        {
            string[] array = new string[] {"0 - Exit", "1 - SortArray", "2 - CheckSpeedSorting", "3 - PositiveNumber","4 - I SEEK YOU" };
            bool isExit = false;
            while (!isExit) 
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
                Console.Write("Insert the number: ");
                int number  = СheckInputNumber();

                switch (number) 
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Thread th1 = new Thread(SortingUnit);
                        Console.WriteLine("Array sorting started, please wait..");
                        Console.WriteLine();
                        th1.Start();
                        th1.Join();
                        break;
                    case 2:            
                        CheckSpeedSorting check = new CheckSpeedSorting();
                        check.ShowSpeedSorting();
                        break;
                    case 3:
                        Console.WriteLine("Insert the number:");
                        string str = Console.ReadLine();           
                        Console.WriteLine(str.IsCheckPositiveNumber());
                        break;
                    case 4:
                        Console.WriteLine("");
                        var speed = new CheckSpeedSorting();
                        speed.ShowSpeedSorting();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
