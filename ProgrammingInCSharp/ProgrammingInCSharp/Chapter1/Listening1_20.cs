using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// When this program runs you might be surprised to see the output below:
/// process finished.
/// Hello from the thread.
/// It looks like the program is printing in the wrong order.
/// However, if you think about it, the order makes sense.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_20
    {
        public static void Listening1_20Main()
        {
            Thread thread = new Thread( () => {
                Console.WriteLine("Hello from the thread.");
                Thread.Sleep(1000);
            });
            thread.Start();
            Console.WriteLine("process finished.");
            Console.ReadKey();

        }
    }
}
