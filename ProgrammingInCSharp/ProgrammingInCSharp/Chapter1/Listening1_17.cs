using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// Code running inside a parent task can create other tsaks, but these "child" tasks will excute independently
/// of the parent in which they were created.
/// The tasks are created by calling the StartNew method on the default Task Factory provided by the Task class.
/// This overload of the StartNew method accepts three parmeters: the lambda expressing giving the behavor of the task, a state object
/// that is passed int the task when it is started , and a TaskCreationOption value that reuests that the new task should be a child task.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_17
    {
        private static void DoChild(object state)
        {
            Console.WriteLine("Child task{0} starting", state);
            Thread.Sleep(1000);
            Console.WriteLine("Child task{0} fnished", state);
        }

        public static void Listening1_17Main()
        {
            var parent = Task.Factory.StartNew( () => {
                Console.WriteLine("parent start.");

                for (int i = 0; i < 10; i++)
                {
                    var taskNo = i;
                    Task.Factory.StartNew(
                        (x) => DoChild(x),
                        taskNo,
                        TaskCreationOptions.AttachedToParent);
                }
            });

            parent.Wait();
            Console.WriteLine("Parent finished.");
            Console.ReadKey();
        }
    }
}
