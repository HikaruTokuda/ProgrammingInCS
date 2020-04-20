using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// The Task.Run method uses the TaskFactory.StartNew method to create and start the task, using the default task scheduler that 
/// uses the .NET framework threadpool.
/// The Run method , however, is the preffered way to create a simpletask, particularly if you want to use the task with async and await.
/// </summary>

namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_13
    {
        public static int CalculateResult()
        {
            Console.WriteLine("Work starting.");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished.");
            return 99;
        }

        public static void Listening1_13Main()
        {
            Task<int> task = Task.Run(() =>
            {
                return CalculateResult();
            });

            Console.WriteLine(task.Result);

            Console.ReadKey();
        }
    }
}
