using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// A Thread instance exposes a range of context information, and some items can be read and others read and set.
/// The Thread.CurrentThread property can be used by a thread to discover this information about itself.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_27
    {
        static void DisplayThread(Thread t)
        {
            Console.WriteLine("Name: {0}", t.Name);
            Console.WriteLine("Culture: {0}", t.CurrentCulture);
            Console.WriteLine("Priority: {0}", t.Priority);
            Console.WriteLine("ExecutionContext: {0}", t.ExecutionContext);
            Console.WriteLine("IsBackground: {0}", t.IsBackground);
            Console.WriteLine("IsThreadPoolThread: {0}", t.IsThreadPoolThread);
        }

        public static  void Listening1_27Main()
        {
            Thread.CurrentThread.Name = "Main method";
            DisplayThread(Thread.CurrentThread);
            Console.ReadKey();
        }
    }
}
