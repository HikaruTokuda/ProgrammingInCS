using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class CalcException : Exception
    {
        public enum CalcErrorCodes
        {
            InvalidNumberText,
            DivideByZero
        }

        public CalcErrorCodes Error { get; set; }

        public CalcException(string message, CalcErrorCodes error)
            : base(message)
        {
            Error = error;
        }
    }

    class Listening1_81
    {
        public static void Listening1_81Main()
        {
            try
            {
                throw new CalcException("Calc failed", CalcException.CalcErrorCodes.InvalidNumberText);
            }
            catch(CalcException ce)
            {
                Console.WriteLine("Error: {0}", ce.Error);
            }
            Console.ReadKey();
        }
    }
}
