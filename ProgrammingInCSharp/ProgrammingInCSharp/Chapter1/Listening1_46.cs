using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Dead Lock sample code.
/// If program run on single thread, runs to completion.
/// Listening1_47 shows that the program run on multi thread in this program .
/// </summary>
namespace ProgrammingInCSharp
{
    class Listening1_46
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

        public static void Listening1_46Main()
        {
            Method1();
            Method2();

            Console.WriteLine("Method complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
