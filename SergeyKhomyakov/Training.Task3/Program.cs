using System;
using System.Collections.Generic;

namespace Training.Task3
{
    class Program
    {
        private static int СheckInputNumber() 
        {
            int number = 0;
            string numberInput = string.Empty;
            Console.Write("Введите число: ");
            numberInput = Console.ReadLine();
            while (!int.TryParse(numberInput, out number) || number < 0)
            {
                if (number < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число");
                }
                else
                {
                    Console.WriteLine("Я не понимаю что вы ввели :(((");
                }
                Console.WriteLine();

                Console.Write("Введите число: ");
                numberInput = Console.ReadLine();
                Console.WriteLine();
            }
            return number;
        }
        /// <summary>
        ///  Task 3.1 
        /// </summary>
        public static void ShowLastPerson() 
        {
            int number = 0;
            int step = 2;
            number = СheckInputNumber();
            List<int> list = new List<int>();
            list = GetСompletedListOf(list, number);
            foreach (var item in list) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            RemovePerson(list, step);
        }

        /// <summary>
        /// Метод заполняет список числами  
        /// </summary>
        /// <param name="number">Размер списка</param>
        /// <returns></returns>
        private static List<int> GetСompletedListOf(List<int> list,int number) 
        {
            for (int i = 1; i < number + 1; i++) 
            {
                list.Add(i);
            }
            return list;
        }
        /// <summary>
        /// Метод удаляет из списка элементы с шагом (step)
        /// </summary>
        /// <param name="step">шаг по списку</param>
        private static void RemovePerson(List<int> list, int step) 
        {
            Console.WriteLine("================");
            int count = list.Count;
            int removeAt = 0;
            while (count != 1) 
            {
                removeAt = (removeAt + step - 1) % count;
                list.RemoveAt(removeAt);
                string.Join(" ", list);
                count--;
            }
            Console.WriteLine($"Остался в живых {list[0]}");
        }   

        /// <summary>
        /// Task 3.2 
        /// </summary>
        public static void ShowWordFrequency()
        {
            string text = "Positive thinking is one of the main hallmarks of self improvement. "
                + "There are many benefits of positive thinking. "
                + "Anyone who is serious about personal growth and improving themselves should and must practice positive thinking."
                + "Positive thinking is somewhat underrated by many people."
                + "This is partly due to the simplicity of the concept and also because of the perception that positive thinking only gives a surface level change and impact."
                + "Contrary to misconceptions, positive thinking isn’t only about looking at the world through rose tinted glasses or ‘fooling’ yourself into thinking that everything is fine when in reality all havoc is breaking loose."
                + "Positive thinking is not about blind optimism benefits of positive thinking."
                + "Rather, positive thinking means having the resourcefulness to stay positive even in times of difficulty and crisis."
                + "It is about looking at things the way it is, but still being in a state of being that is conducive to growth and success."
                + "It is staying calm and knowing deep within that anything can be resolved regardless of the situation."
                + "It is having the ability to look beyond what is happening on the surface and see the bigger, long term picture instead."
                + "That is where the biggest benefits of positive thinking are realized."
                + "There are many reasons why you should take positive thinking seriously and practice it everyday. ";
            char[] delimiterChars = { ' ', '.',',' };
            text = text.ToLower();
            string[] words = text.Split(delimiterChars);
            var pairs = GetWordFrequency(words);
            foreach (var item in pairs) 
            {
                Console.WriteLine($"Word [{item.Key}] Quantity [{item.Value}]");
            }
        }

        private static SortedDictionary<string, int> GetWordFrequency(string[] words)
        {
            SortedDictionary<string, int> pairs = new SortedDictionary<string, int>();
            foreach (var item in words)
            {
                if (item == "" || item == null)
                {
                    continue;
                }
                else 
                {
                    try
                    {
                        pairs.Add(item, 1);
                    }
                    catch (ArgumentException) 
                    {
                        pairs[item] += 1;
                    }
                }               
            }

            return pairs;
        }
        static void Main(string[] args)
        {

            int number = 0;
            bool isExit = false;
            string[] arraymenu = new string[] { "0 - Exit", "1 - Lost", "2 - Word Frequency" };
            while(!isExit)
            {
                Console.WriteLine("====================");
                foreach (var item in arraymenu) 
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("====================");
                number = СheckInputNumber();
                switch (number) 
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Console.WriteLine("Введите количество человек ");
                        ShowLastPerson();
                        break;
                    case 2:
                        ShowWordFrequency();
                        break;
                    default:
                        Console.WriteLine("Число не найдено !");
                        break;
                }
            }

        }
    }
}
