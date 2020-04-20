using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace ProgrammingInCSharp
{
    class Listening1_39
    {
        public static void Listening1_39Main()
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();

            bag.Add("Rob");
            bag.Add("Miles");
            bag.Add("Hull");
            string str;
            if (bag.TryPeek(out str))
                Console.WriteLine("Peek; {0}", str);
            if (bag.TryTake(out str))
                Console.WriteLine("Pop: {0}", str);

            Console.ReadKey();
        }
    }
}
