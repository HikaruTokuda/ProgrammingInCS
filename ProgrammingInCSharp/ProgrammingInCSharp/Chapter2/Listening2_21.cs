using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Boxing and unboxing
/// It can be useful to treat value types as reference types, and the C# runtime system provides a mechanism
/// called "boxing" that will perform this conversion when required. Listening2_21 shows boxing and unboxing
/// being performed in a program.The first statement takes the value 99 and casts this into an object called o.
/// The second statement takes the object o and casts it back into an integer.
/// The process of converting from a reference type(reference o) into a value type(the integer oVal) is called
/// "unboxing".
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_21
    {
        public static void Listening2_21Main()
        {
            // the value 99 is boxed into an object
            object o = 99;

            // the boxed object is unboxed back into an int
            int oValue = (int)o;
            Console.WriteLine(oValue);

            Console.ReadKey();
        }
    }
}
