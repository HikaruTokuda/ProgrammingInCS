using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_76
    {
        public static void Listening1_76Main()
        {
            try
            {
                Console.Write("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result;
                result = int.Parse(numberText);
                Console.WriteLine("You enterd {0}", result);
            }
            catch
            {
                Console.WriteLine("Invalid number entered");
            }
            Console.ReadKey();
        }
    }
}
