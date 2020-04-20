using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



/// <summary>
/// Threads are a lower level of abstruction than Tasks.
/// A Task object represents  an item of work to be performed, whereaas a Thread object represents a process running within the operating system.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_18
    {
        private static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread.");
            Thread.Sleep(1000);
        }

        public static void Listening1_18Main()
        {
            Thread thread = new Thread(ThreadHello);
            thread.Start();

            Console.WriteLine("Process finished.");
            Console.ReadKey();
        }
    }
}
