using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// A task can also be created and star runnning a single method, called Run, as shown in Listening1_12
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_12
    {
        public static void DoWork()
        {
            Console.WriteLine("Work starting.");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished.");
        }

        public static void Listening1_12Main()
        {
            Task newTask = Task.Run( () => DoWork());
            newTask.Wait();

            Console.ReadKey();
        }
    }
}
