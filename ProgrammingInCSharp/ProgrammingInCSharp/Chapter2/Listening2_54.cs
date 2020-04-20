using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/// <summary>
/// Calling a method on an object by using reflection.
/// You can use the information provided by a type to create a call to a method in that type.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_54
    {
        public static void Listening2_54Main()
        {
            Type type;

            Person2 p = new Person2();
            type = p.GetType();

            MethodInfo setMethod = type.GetMethod("set_Name");
            setMethod.Invoke(p, new object[] { "Fred" });

            Console.WriteLine(p.Name);

            Console.ReadKey();
        }


        


    }
}
