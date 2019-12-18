using System;
using System.Diagnostics;

namespace Training.Task4
{
    class СheckSpeedSorting
    {
        public void ShowSpeedSorting()
        {
            int N = 100000;
            int[] array = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1024, 1024);
            }
            Stopwatch stopWatch = new Stopwatch();
            ISeekYou seekYou = new ISeekYou();
            int count = 1000;
            while (count != 0) 
            {
                stopWatch.Start();
                Console.WriteLine(seekYou.GetMax(array));
                stopWatch.Stop();
                Console.WriteLine($"Обычный поиск : {stopWatch.Elapsed}");
                stopWatch.Restart();

                stopWatch.Start();
                seekYou.GetMaxDelegate(array, seekYou.EqualsInt);
                stopWatch.Stop();
                Console.WriteLine($"Поиск с экземпляром делегата: {stopWatch.Elapsed}");
                stopWatch.Restart();

                stopWatch.Start();
                seekYou.GetMaxDelegate(array, delegate (int i, int j) { return i < j; });
                stopWatch.Stop();
                Console.WriteLine($"Поиск через делегат в виде анонимного метода: {stopWatch.Elapsed}");
                stopWatch.Restart();

                stopWatch.Start();
                seekYou.GetMaxDelegate(array, (i, j) => i < j);
                stopWatch.Stop();
                Console.WriteLine($"Поиск через делегат в виде лямбда-выражения: {stopWatch.Elapsed}");
                stopWatch.Restart();

                stopWatch.Start();
                seekYou.GetMaxLinq(array);
                stopWatch.Stop();
                Console.WriteLine($"Поиск через LINQ-выражения: {stopWatch.Elapsed}");
                stopWatch.Restart();

                count--;
            }

            Console.ReadKey();
        }
    }
}
