using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_83
    {
        public static void Listening1_83Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter an integer: ");
                    string numberText = Console.ReadLine();
                    int sum = int.Parse(numberText);
                }
                catch (Exception ex)
                {
                    throw new Exception("Calculater failed.", ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
