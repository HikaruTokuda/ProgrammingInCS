using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_54
    {
        static int counter;

        static void Initialize()
        {
            Console.WriteLine("Initialize called.");
            counter = 0;
        }

        static void Update()
        {
            Console.WriteLine("update called.");
            counter = counter + 1;
        }

        static bool Test()
        {
            Console.WriteLine("Test called.");
            return counter < 5;
        }

        public static void Listening1_54Main()
        {
            for (Initialize(); Test(); Update())
            {
                Console.WriteLine("Hello {0}", counter);
            }

            Console.ReadKey();
        }
    }
}
