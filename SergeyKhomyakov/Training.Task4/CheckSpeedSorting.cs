using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Training.Task4
{
    class CheckSpeedSorting
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
            var time = new List<long>();
            int count = 1000;

            for (int i = 0; i < count; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                seekYou.GetMax(array);
                time.Add(stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"Regular search : {time.Average()} msec");

            time.Clear();
            for (int i = 0; i < count; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                seekYou.GetMaxDelegate(array, seekYou.EqualsInt);
                time.Add(stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"Search with delegate instance: {time.Average()} msec");

            time.Clear();
            for (int i = 0; i < count; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                seekYou.GetMaxDelegate(array, delegate (int x, int y) { return x < y; });
                time.Add(stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"Search through a delegate as an anonymous method: {time.Average()} msec");

            time.Clear();
            for (int i = 0; i < count; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                seekYou.GetMaxDelegate(array, (x, y) => x < y);
                time.Add(stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine($"Search through a delegate as a lambda expression: {time.Average()} msec");

            time.Clear();
            for (int i = 0; i < count; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                seekYou.GetMaxLinq(array);
                time.Add(stopWatch.ElapsedMilliseconds);
            } 
            Console.WriteLine($"Search through LINQ Expressions: {time.Average()} msec");
        }            
    }
}
