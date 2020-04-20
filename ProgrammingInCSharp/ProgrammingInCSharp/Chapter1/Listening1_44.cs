using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The sub-total is then added to the total value once this loop has completed.Rather than updating 
/// every time it adds anew element of the array; this version of the method only updates the shared total once.
/// </summary>
namespace ProgrammingInCSharp
{
    class Listening1_44
    {
        static long sharedTotal;
        static int[] items = Enumerable.Range(0, 500001).ToArray();
        static object sharedTotalLock = new object();


        static void AddRangeOfValues(int start, int end)
        {
            long subTotal = 0;

            while (start < end)
            {
                subTotal = subTotal + items[start];
                start++;
            }

            lock (sharedTotalLock)
            {
                sharedTotal = sharedTotal + subTotal;
            }
        }

        public static void Listening1_44Main()
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
