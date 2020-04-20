using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// Another way to pass the data into a thread is to specify the behavor of the thread as a lambda expression that accepts a parameter.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_22
    {
        private static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }

        public static void Listening1_22Main()
        {
            Thread thread = new Thread( (data) => WorkOnData(data) );
            thread.Start(99);

            Console.ReadKey();
        }
    }
}
