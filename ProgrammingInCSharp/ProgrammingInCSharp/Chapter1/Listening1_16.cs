using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// The method World task is only called when HelloTask() finished sucessfuly.
/// If the task HelloTask method failure, the method ExceptionTask() is ccalled.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_16
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

        public static void FailureTask()
        {
            try
            {
                int[] nullInt = null;
                Console.WriteLine(nullInt[0]);
            }
            catch
            {
                throw new Exception();
            }

        }

        public static void ExceptionTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Failure to excute task");
        }

        public static void Listening1_16Main()
        {
            Task task = Task.Run(() => HelloTask());
            //Task task = Task.Run(() => FailureTask());
            task.ContinueWith((prevTask) => WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith((prevTask) => ExceptionTask(), TaskContinuationOptions.OnlyOnFaulted);

            Console.WriteLine("Finished processing.");
            Console.ReadKey();
        }
    }
}
