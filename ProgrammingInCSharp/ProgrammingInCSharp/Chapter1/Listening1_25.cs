using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// The Join method allows two thread to synchronize.
/// When a thread calls the join method on another thread, the caller of join is helf until the other thread complete.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_25
    {
        public static void Listening1_25Main()
        {
            Thread threadToWaitFor = new Thread( () => {
                Console.WriteLine("Thread starting.");
                Thread.Sleep(1000);
                Console.WriteLine("Thread finished.");
            });

            threadToWaitFor.Start();
            Console.WriteLine("Joinig thread.");
            threadToWaitFor.Join();
            Console.WriteLine("Press key to exit.");
            Console.ReadKey();
        }
    }
}
