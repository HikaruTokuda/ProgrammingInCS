using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Use ExpandoObject
/// </summary>
using System.Dynamic;
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_25
    {
        public static void Listening2_25Main()
        {
            dynamic person = new ExpandoObject();

            person.Name = "Rob Miles";
            person.Age = 21;

            Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            Console.ReadKey();

        }
    }
}
