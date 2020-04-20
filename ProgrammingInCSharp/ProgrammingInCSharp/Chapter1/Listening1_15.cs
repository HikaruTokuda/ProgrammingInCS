using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// Listening1-15 shows how a continuaution task can be created from a task.
/// The countinueWith method has an oveload that you can use to specify when a given continuation task can run.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_15
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World");
        }

        public static void Listening1_15Main()
        {
            Task task = Task.Run(() => HelloTask());
            task.ContinueWith( (prevTask) => WorldTask() );

            Console.WriteLine("Finished processing.");
            Console.ReadKey();
        }
    }
}
