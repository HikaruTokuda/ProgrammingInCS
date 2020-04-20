using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Extension Method
/// A class provide methods for other classes to call.You will see how a class can be extended by a childe
/// class that can add mambers to the base class, including new methods that can implement additional behaviors.
/// However, extension methods provide a way in which behaviors can be added to  a class without needing to 
/// extend the class itself.
/// You can think of the extension methods as being "bolted on" to an existing class.
/// Listening2_13 shows how create an extension method for the String class. The first parameter to method specifies
/// the type that the extension method should be added to, by using keyword "this" followed by the name of the type.
/// </summary>
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int LineCount(this String str)
        {
            return str.Split(new char[] { '\n' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

/// <summary>
/// Once the extension method has been created it can be used from the namespace in which the class containing
/// the method is declared.When the program calls an extension method the compiler searches the included namespace
/// for a matching method for that type, and then generates a call of that method, When the program runs,
/// it prints out the number of lines in the string text.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    using ExtensionMethods;

    class Listening2_13
    {
        public static void Listening2_13Main()
        {
            string text = @"A rocket explore called Wright,
Once travelled much faster than light,
He set out one day,
In a relative way,
And returned on the previous night.";

            Console.WriteLine(MyExtensions.LineCount(text));
            Console.ReadKey();
        }

    }
}
