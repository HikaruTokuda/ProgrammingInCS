using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// The important difference between thread and tasks, in that a Thread can be aborted at any time, whereas a Task must monitor
/// a acancellation token so that it will end when told to.
/// </summary>

namespace ProgrammingInCSharp
{
    class Listening1_49
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        static void Clock()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }
        }

        public static void Listening1_49Main()
        {
            Task.Run(() => Clock());
            Console.WriteLine("Press any key to stop the clock.");
            Console.ReadKey();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Clock Stopped.");
            Console.ReadKey();
        }
    }
}
