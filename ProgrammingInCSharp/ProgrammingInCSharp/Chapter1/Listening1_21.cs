using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// A program can pass data into a thread when it is created by using the ParameterizedThreadStart delegate.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_21
    {
        private static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }

        public static void Listening1_21Main()
        {
            ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
            Thread thread = new Thread(ps);
            thread.Start(99);

            Console.ReadKey();
        }
    }
}
