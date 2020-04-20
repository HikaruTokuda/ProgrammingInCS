using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// Note that earlier version of .NET required the creattion of ThreadStart delegate.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_19
    {
        private static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread.");
            Thread.Sleep(1000);
        }

        public static void Listening1_19Main()
        {
            ThreadStart ts = new ThreadStart(ThreadHello);
            Thread thread = new Thread(ts);
            thread.Start();

            Console.WriteLine("Process finished.");
            Console.ReadKey();
        }
    }
}
