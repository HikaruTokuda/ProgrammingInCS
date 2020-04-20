using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    /// <summary>
    /// create a handler that only catches exceptions that contaion particular data values.
    /// </summary>
    class Listening1_82
    {
        public static void Listening1_82Main()
        {
            try
            {
                throw new CalcException("Calc failed", CalcException.CalcErrorCodes.DivideByZero);
            }
            catch (CalcException ce) when (ce.Error == CalcException.CalcErrorCodes.DivideByZero)
            {
                Console.WriteLine("Divide by zero error");
            }
            Console.ReadKey();
        }
    }
}
