using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IEnumerable
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_41_42
    {
        public static void Listening2_41_42Main()
        {
            // Get an enumrator that can iterate through a string
            var stringEnumrator = "Hello world".GetEnumerator();

            List2_41(stringEnumrator);
            List2_42("Hello world");
            Console.ReadKey();
        }

        static void List2_41(CharEnumerator stringEnumrator)
        {
            while (stringEnumrator.MoveNext())
            {
                Console.WriteLine(stringEnumrator.Current);
            }
        }

        static void List2_42(string str)
        {
            foreach (var ch in str)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
