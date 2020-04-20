using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IDisposable
/// The IDisposable interface provides away that an object can indicate that it contaions an explict Dispose method
/// that can be used to tidy up an object an object when an application has finished using it.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class CrucialConnection : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose called.");
        }
    }

    class Listening2_45
    {
        public static void Listening2_45Main()
        {
            using (CrucialConnection c = new CrucialConnection())
            {
                // do something with the crucial connection
            }

            Console.ReadKey();
        }
    }
}
