using System;
using System.Reflection;

/// <summary>
/// Use types from the System.Reflection namespace.
/// Assembly
/// An assembly is the output produced when a .NET project is compiled. The assembly type represents the contents of an assembly, which can be the currently executing assembly or 
/// one that is loaded from a file.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_60
    {
        public static void Listening2_60Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine("Full name: {0}", assembly.FullName);
            AssemblyName name = assembly.GetName();
            Console.WriteLine("Major Version: {0}", name.Version.Major);
            Console.WriteLine("Minor Version: {0}", name.Version.Minor);
            Console.WriteLine("In global assembly cache: {0}", assembly.GlobalAssemblyCache);

            foreach (Module assemblyModule in assembly.Modules)
            {
                Console.WriteLine(" Module: {0}", assemblyModule.Name);

                foreach (Type moduleType in assemblyModule.GetTypes())
                {
                    Console.WriteLine("     Types: {0}", moduleType.Name);

                    foreach (MemberInfo member in moduleType.GetMembers())
                    {
                        Console.WriteLine("         Member: {0}", member.Name);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
