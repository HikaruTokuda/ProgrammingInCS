using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// This code requires careful study.Note that if you run the program in VisualStudio and press key to interupt the clock,
/// Visial Studio will reportan unhandled exception int the Clock method.
/// </summary>
namespace ProgrammingInCSharp
{
    class Listening1_50
    {
        static void Clock(CancellationToken cancellationToken)
        {
            int tickCount = 0;
            while (!cancellationToken.IsCancellationRequested && tickCount < 20)
            {
                tickCount++;
                Console.WriteLine("Tick");
                Thread.Sleep(500);
            }

            cancellationToken.ThrowIfCancellationRequested();
        }

        public static void Listening1_50Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            Task clock = Task.Run( () => Clock(cancellationTokenSource.Token) );

            Console.WriteLine("Press any key to stop the clock.");
            Console.ReadKey();

            if (clock.IsCompleted)
            {
                Console.WriteLine("Clock task completed.");
            }
            else
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    clock.Wait();
                }
                 /*catch(AggregateException ex)*/
                 catch(OperationCanceledException ex)
                {
                    //Console.WriteLine("Clock stopped: {0}", ex.InnerExceptions[0].ToString());
                    Console.WriteLine("Clock stopped");
                }
            }
            Console.ReadKey();
        }
    }
}
