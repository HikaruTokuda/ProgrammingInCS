using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// different threads use the value of their RandomGenerator they will all produce the same sequence of random numbers.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_26
    {
        /*
        public static ThreadLocal<Random> RandomGenerator = new ThreadLocal<Random>(() => {
        return new Random(2);
        });
        */
        public static ThreadLocal<int> RandomGenerator = new ThreadLocal<int>(() => {
            return 5;
        });

        public static void Listening1_26Main()
        {
            /*
            Random random = new Random();
            random.Next();
            */
            Thread t1 = new Thread( () => {
                for(int i =0; i < 5; i++)
                {
                    //Console.WriteLine("t1: {0}", RandomGenerator.Value.Next(10));
                    Console.WriteLine("t1: {0}", RandomGenerator.Value);
                    Thread.Sleep(500);
                }
            });

            Thread t2 = new Thread(() => {
                for (int i = 0; i < 5; i++)
                {
                    //Console.WriteLine("t2: {0}", RandomGenerator.Value.Next(10));
                    Console.WriteLine("t2: {0}", RandomGenerator.Value);
                    Thread.Sleep(500);
                }
            });

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
    }
}
