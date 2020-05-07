using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingInCSharp.Chapter1;
using ProgrammingInCSharp.Chapter2;
using ProgrammingInCSharp.Chapter3;

/// <summary>
/// When designing an application, you should also decide how the application will respond to any error conditions.
/// This can include the creation of custom exception type for your program.
/// ※This code would, of course, be much slower than just setting the Name property to the value "Fred", but it illustrates the
/// flexibility provided by reflection.
/// </summary>
namespace ProgrammingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Listening3_1.Listening3_1Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            

            //System.Windows.Forms.Application.Run(new Listening1_32());
        }
    }
}
