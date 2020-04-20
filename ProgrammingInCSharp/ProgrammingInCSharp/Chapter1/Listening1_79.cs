using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_79
    {
        public static void Listening1_79Main()
        {
            try
            {
                Console.WriteLine("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result = int.Parse(numberText);
                int sum = 1 / result;
                Console.WriteLine("Sum is {0}", sum);
            }
            catch (NotFiniteNumberException nx)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (DivideByZeroException zx)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception");
            }
            finally
            {
                Console.WriteLine("Thanks for using my program.");
            }
            Console.ReadKey();
        }
    }
}
