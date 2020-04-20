using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Create an enum
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{

    enum AlienState
    {
        Sleeping,
        Attacking,
        Destroyed
    }

    class Listening2_4
    {
        public static void Listening2_4Main()
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
