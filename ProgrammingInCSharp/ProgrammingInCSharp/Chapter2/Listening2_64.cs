using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Object finalization using a finalizer method.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Person2_64
    {
        long[] personArray = new long[1000000];

        ~Person2_64()
        {
            // This is where the Person would be finalized.
            Console.WriteLine("Finalizer called.");
            Console.ReadKey();
        }
    }

    class Listening2_64
    {
        public static void Listening2_64Main()
        {

            Person2_64 p = new Person2_64();
            System.Threading.Thread.Sleep(3);

        }
    }
}
