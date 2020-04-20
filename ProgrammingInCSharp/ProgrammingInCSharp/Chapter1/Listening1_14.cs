using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// The task.Waitall method can be used to pause a program until a number of task have completed, as shown Listening1-14.
/// This listening also illustrates an additional issue with the use of loop control variables when they are passed into lambda
/// expression.
/// The loop counter is copied into a local variable called taskNum in the loop that creates each task.
/// If the variable i was used directly in the lambda expression, all of the tasks would have number 10, which is the value of the limit
/// of the loop.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_14
    {
        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting.", i);
            Thread.Sleep(1000);
            Console.WriteLine("Task {0} finished.", i);
        }

        public static void Listening1_14Main()
        {
            Task[] tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                // make a local copy of the loop counter so that the
                // correct task number is passed into the lambda expression.
                int taskNum = i;
                tasks[i] = Task.Run(() => DoWork(taskNum));
            }
            //Task.WaitAll(tasks);          // wait all tasks hasve finished.
            Task.WaitAny(tasks[3]);            // wait a task of all tasks have finished.
            Console.WriteLine("Finished processing.");
            Console.ReadKey();
        }
    }
}
