using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// If an application creates a large number of threds, each of these will require an object to be created and the destroyed 
/// when the thread completes.
/// A threadpool stores a collection of reusable thread objects.
/// When the thread completes, the thread is returned to the pool for use by another process.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_28
    {
        static void DoWork(object state)
        {
            Console.WriteLine("Doing work: {0}", state);
            Thread.Sleep(1000);
            Console.WriteLine("Doing finished: {0}", state);
        }

        public static void Listening1_28Main()
        {
            for (int i = 0; i < 50; i++)
            {
                int stateNumber = i;
                ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
            }
            Console.ReadKey();
        }
    }
}
