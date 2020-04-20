using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/// <summary>
/// Use refrection.
/// Searching for and reading attribute values is an example of a program performing reflection.
/// The type of object contains all the fields of an object, along with all the metadata describing the object.
/// You can use methods and objects in the System.Reflection namespace to work with Type object.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Person2
    {
        public string Name { get; set; }
    }

    class Listening2_53
    {
        public static void Listening2_53Main()
        {
            System.Type type;

            Person2 p2 = new Person2();
            type = p2.GetType();

            foreach (MemberInfo member in type.GetMembers())
            {
                Console.WriteLine(member.ToString());
            }

            Console.ReadKey();
        }
    }
}
