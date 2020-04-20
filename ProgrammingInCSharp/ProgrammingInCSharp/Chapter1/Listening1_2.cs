using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// The Task.Parallel class also provide a ForEach method that performs a parallel implementation of the foreach loop construction.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_2
    {
        public static void Listening1_2_Main()
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
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
