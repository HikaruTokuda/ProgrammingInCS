using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// When a thread is aborted it is instantly stopped. it might mean that it leaves the program in an ambiguous state, with files open and
/// resources assigned.
/// A better way to abort thread is to use shared flag variable.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_24
    {
        static bool tickRunnning;

        public static void Listening1_24Main()
        {
            tickRunnning = true;

            Thread thread = new Thread( () => {
                while (tickRunnning)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            thread.Start();
            Console.WriteLine("Press key to stop thread.");
            Console.ReadKey();
            tickRunnning = false;

            Console.WriteLine("Thread finished");
            Console.ReadKey();
        }
    }
}
