using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;


/// <summary>
/// The adding task calls the CompleteAdding on the collection when it has added the last item.
/// The task taking from the collection uses the IsComplete property of the collection to
/// determine when to stop taking items from it.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_35
    {
        public static void Listening1_35Main()
        {
            // Blocking collection that can hold 5 items.
            BlockingCollection<int> data = new BlockingCollection<int>(5);

            Task.Run( () =>
            {
                // attempt to add 10 items to the collection - blocks after 5th
                for (int i = 0; i < 11; i++)
                {
                    data.Add(i);
                    Console.WriteLine("Data {0} added successfully.", i);
                }

                // indicate we have no more to add
                data.CompleteAdding();
            });

            Console.ReadKey();
            Console.WriteLine("Reading collection.");

            Task.Run( () =>
            {
                try
                {
                    while (!data.IsCompleted)
                    {
                        int v = data.Take();
                        Console.WriteLine("Data {0} taken successfuly.", v);
                    }
                }
                catch(InvalidOperationException){}
            });

            Console.ReadKey();
        }
    }
}
