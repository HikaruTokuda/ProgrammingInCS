using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;


namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_37
    {
        public static void Listening1_37Main()
        {
            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
            queue.Enqueue("Rob");
            queue.Enqueue("Miles");

            string str;
            if (queue.TryPeek(out str))
                Console.WriteLine("Peek: {0}", str);
            if (queue.TryDequeue(out str))
                Console.WriteLine("Dequeue; {0}", str);

            Console.ReadKey();
        }
    }
}
