using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_41
    {
        // make an array that holds the values 0 to 50000000
        static int[] items = Enumerable.Range(0, 500000001).ToArray();

        public static void Listening1_41Main()
        {
            long total = 0;
            for (int i = 0; i < items.Length; i++)
            {
                total = total + items[i];
            }

            Console.WriteLine("The total is {0}", total);
            Console.ReadKey();
        }
    }
}
