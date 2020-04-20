using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Rethrow an exception
/// catch(Exception ex)
/// {
///     throw ex;
/// }
/// This is bad practice because it will remove the stack trace information that is part of the original
/// exception and replace it with stack trace information that describes the position reached in the exception handler to
/// deal with.
/// </summary>
namespace ProgrammingInCSharp
{
    class Listening1_80
    {
        public static void Listening1_80Main()
        {
            try
            {
                Console.WriteLine("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result = int.Parse(numberText);
                int sum = 1 / result;
                Console.WriteLine("Sum is {0}", sum);
            }
            catch (DivideByZeroException zx)
            {
                Console.WriteLine(zx.Message);
                throw new DivideByZeroException("something had happened", zx);
            }
        }

        
    }
}
