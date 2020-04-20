using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// A thread object exposs an Abort method, which can be called ont the thread to abort it.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_23
    {
        public static void Listening1_23Main()
        {
            Thread thread = new Thread( () => {
                while (true)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });

            thread.Start();
            Console.WriteLine("Press key to stop thread.");
            Console.ReadKey();

            thread.Abort();

            Console.WriteLine("Thread finished");
            Console.ReadKey();
        }
    }
}
