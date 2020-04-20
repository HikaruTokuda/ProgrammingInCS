using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// Listening1_11 creates task, starts it runnning, and then waits for the task to complete.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_11
    {
        public static void DoWork()
        {
            Console.WriteLine("Work starting.");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished.");
        }

        public static void Listening1_11Main()
        {
            Task newTask = new Task( () => DoWork());
            newTask.Start();
            newTask.Wait();

            Console.ReadKey();
        }
    }
}
