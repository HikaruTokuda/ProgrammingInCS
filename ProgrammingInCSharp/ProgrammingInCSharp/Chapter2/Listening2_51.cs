using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ??
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_51
    {
        public static void Listening2_51Main()
        {
            Attribute a = Attribute.GetCustomAttribute(typeof(Person), typeof(ProgrammerAttribute));
            ProgrammerAttribute p = (ProgrammerAttribute)a;

            Console.WriteLine("Programmer: {0}", p.Programmer);
        }
    }
}
