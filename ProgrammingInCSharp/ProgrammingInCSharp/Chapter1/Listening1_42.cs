using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Apparently many updates to the variable sharedTotal didn't take place.
/// The problem is caused by the way in which all of the tasks interact over the same shared
/// value.Consider the following sequence of events.
/// 1. Task number 1 starts performing an update of sharedTotal. If fetches the contents of the sharedTotal
/// variable into CPU and adds the contetnts of an array element to the value of sharedTotal.
/// But just as the CPU is about to write the result back into memory, the OS stops task number 1 and
/// switches to task number 2.
/// 2. Task number 2 also wants to update sharedTotal. If fetches the content of sharedTotal, adds the value of
/// an array elements to it, and then write the result back into memory.
/// Now OS returns control to task number 1.
/// 3.Task number 1 writes the sharedTotal value it was working on from the CPU back into memory.
/// This means that the update performed by task number 2 has been lost.
/// </summary>

namespace ProgrammingInCSharp
{
    class Listening1_42
    {
        static long sharedTotal;
        static int[] items = Enumerable.Range(0, 500001).ToArray();


        static void AddRangeOfValues(int start, int end)
        {
            while (start < end)
            {
                sharedTotal = sharedTotal + items[start];
                start++;
            }
        }

        public static void Listening1_42Main()
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

                tasks.Add( Task.Run( () => AddRangeOfValues(rs, re)) );
                rangeStart = rangeEnd;
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("The total is {0}", sharedTotal);
            Console.ReadKey();
        }
    }
}
