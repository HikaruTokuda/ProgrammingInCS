using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;




/// <summary>
/// The Parallel.Invoke method can start alarge number of tasks at once.
/// The Parallel.Invoke mehod returns when all of the tasks have complited.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_1
    {
        public static void Listening1_1_Main()
        {
            Parallel.Invoke( () => Task1(), ()=> Task2());
            Console.WriteLine("Finidh processing.");
            Console.ReadKey();
        }
        
        static void Task1()
        {
            Console.WriteLine("Task1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task2 ending");
        }
    }
}
