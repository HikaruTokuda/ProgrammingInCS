using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/// <summary>
/// Finding components in assemblies.
/// You have seen how a program can dynamically locate members of a class but to implement plugins you need to be able to 
/// search the classes in an assembly and find components that implement particular interfaces. This behavior is the basis of the Managed
/// Extensibility Framework(MEF).
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_55
    {
        public static void Listening2_55Main()
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            List<Type> AccountTypes = new List<Type>();

            foreach (Type t in thisAssembly.GetTypes())
            {
                Console.WriteLine(t.ToString());
                if (t.IsInterface) continue;
                if (typeof(IAccount).IsAssignableFrom(t))
                {
                    AccountTypes.Add(t);
                }
            }
            
            foreach (Type t in AccountTypes)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(t.ToString());
            }
            

            Console.ReadKey();
        }        
    }
}
