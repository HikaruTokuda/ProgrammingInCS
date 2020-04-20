using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Use locks to prevent from interacting in dengerous ways, but while you have stopped tasks from interacting
/// in a dangerous manner, you've also removed any benefit from using multi-tasking.
/// </summary>

namespace ProgrammingInCSharp
{
    class Listening1_43
    {
        static long sharedTotal;
        static int[] items = Enumerable.Range(0, 500001).ToArray();
        static object sharedTotalLock = new object();

        static void AddRangeOfValues(int start, int end)
        {
            while (start < end)
            {
                lock (sharedTotalLock)
                {
                    sharedTotal = sharedTotal + items[start];
                    start++;
                }
            }
        }

        public static void Listening1_43Main()
        {
            List<Task> tasks = new List<Task>();

            int rangeSize = 1000;
            int rangeStart = 0;

            while (rangeStart < items.Length)
            {
                int rangeEnd = rangeStart + rangeSize;

                if (rangeEnd > items.Length)
                    rangeEnd = items.Length;

                // create local copy of the parameters
                int rs = rangeStart;
                int re = rangeEnd;

                tasks.Add(Task.Run(() => AddRangeOfValues(rs, re)));
                rangeStart = rangeEnd;
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("The total is {0}", sharedTotal);
            Console.ReadKey();
        }
    }
}
