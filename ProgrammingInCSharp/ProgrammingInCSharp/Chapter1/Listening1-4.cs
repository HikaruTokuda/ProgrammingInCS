using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// this iteration can be ended by calling the Stop or Break methods on the ParallelLoopState variable.
/// this method does not stop at 200...?
/// and result.LowestBreakIteration is null...
/// I wonder if I use Break method not Stop methos...
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_4
    {
        public static void Listening1_4Main()
        {
            var items = Enumerable.Range(0, 500).ToArray();

            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                
                if (i == 200)
                {
                    Console.WriteLine("processing at: " + items[i]);
                    loopState.Stop();
                }
                
                Console.WriteLine("processing at: " + items[i]);
            });

            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration);

            Console.ReadKey(); ;

        }

        
    }
}
