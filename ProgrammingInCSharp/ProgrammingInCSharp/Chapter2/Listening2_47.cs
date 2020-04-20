
//#define TERSE
#define VERBOSE
using System;
using System.Diagnostics;

/// <summary>
/// Conditional compilation using attributes.
/// The symbols TERSE and VERBOSE can be used to select the level of logging that is performed by a program. If the TERSE symbol is defined the body of the terseReport
/// method will be obeyed when the method is called.
/// If the VERBOSE symbols are defined the body of the verboseReport method will be obeyed. The body of the reportHeader method will be obeyed if either the TERSE or the
/// VERBOSE symbols are defined because two attributes are combined before that method definition.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_47
    {
        [Conditional("VERBOSE"), Conditional("TERSE")]
        static void reportHeader()
        {
            Console.WriteLine("This is the header for report.");
        }

        [Conditional("VERBOSE")]
        static void verboseReport()
        {
            Console.WriteLine("This is output from the verbose report.");
        }

        [Conditional("TERSE")]
        static void terseReport()
        {
            Console.WriteLine("This is output from the terse report.");
        }

        public static void Listening2_47Main()
        {
            reportHeader();
            verboseReport();
            terseReport();
            Console.ReadKey();
        }
    }
}
