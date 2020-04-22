using System;
using System.Reflection;

/// <summary>
/// Use Types from the System.Reflection namespace.
/// PropertyInfo
/// A C# property provides a aquick way of providing get and set behaviors for a data variable in a type.
/// The PropertyInfo class provides details of property, including the MethodInfo information for the get and set behaviors if they
/// are present.
/// Listening2_61 enumerates the properties in a type and print information about each one.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    public class Person2_61
    {
        public string Name { get; set; }
        public int Age{ get; }

    }

    class Listening2_61
    {
        public static void Listening2_61Main()
        {
            Type type = typeof(Person2_61);

            foreach (PropertyInfo p in type.GetProperties())
            {
                Console.WriteLine("Propertt name: {0}", p.Name);
                if (p.CanRead)
                {
                    Console.WriteLine("Can read");
                    Console.WriteLine("Get method: {0}", p.GetMethod);
                }
                if (p.CanWrite)
                {
                    Console.WriteLine("Can write");
                    Console.WriteLine("Set method: {0}", p.SetMethod);
                }
            }
            Console.ReadKey();
        }
    }
}
