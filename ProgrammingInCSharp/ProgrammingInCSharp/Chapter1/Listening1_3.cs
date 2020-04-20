using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// the implements a counter starting at 0 for the length of items array.
/// the 3rd parameter of the method is a lambdaexpression, which is passed a variable that provides the counter value for each iteration.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_3
    {
        public static void Listening1_3Main()
        {
            var items = Enumerable.Range(0, 500).ToArray();

            Parallel.For(0, items.Length, i =>
            {
                WorkOnItem(items[i]);
            });
            Console.WriteLine("Finished processing.");
            Console.ReadKey();
        }

        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started work on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished work on: " + item);
        }

    }
}
