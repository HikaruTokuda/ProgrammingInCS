using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The tasks in this case never complete.
/// Each task is waiting for the other's lock object, and neither can continue.
/// Writing the wxample in Listening1_47 was difficult for me to do.When using synchronization objects,
/// I make sure to never "nest" one use of a lock inside another.
/// </summary>

namespace ProgrammingInCSharp
{
    class Listening1_47
    {
        static object lock1 = new object();
        static object lock2 = new object();

        static void Method1()
        {
            lock (lock1)
            {
                Console.WriteLine("Method 1 got lock 1");
                Console.WriteLine("Method 1 waiting for lock 2");

                lock (lock2)
                {
                    Console.WriteLine("Method 1 got lock 2");
                }
                Console.WriteLine("Method 1 released lock 2");
            }
            Console.WriteLine("Method 1 released lock 1");
        }

        static void Method2()
        {
            lock (lock2)
            {
                Console.WriteLine("Method 2 got lock 2");
                Console.WriteLine("Method 2 waiting for lock 1");

                lock (lock1)
                {
                    Console.WriteLine("Method 2 got lock 1");
                }
                Console.WriteLine("Method 2 released lock 1");
            }
            Console.WriteLine("Method 2 released lock 2");
        }

        public static void Listening1_47Main()
        {
            Task t1 = Task.Run( () => Method1() );
            Task t2 = Task.Run( () => Method2() );
            Console.WriteLine("waiting for task 2");
            t2.Wait();

            Console.WriteLine("Tasks complete. Press any key to exit.");
            Console.ReadKey();
        }

    }
}
