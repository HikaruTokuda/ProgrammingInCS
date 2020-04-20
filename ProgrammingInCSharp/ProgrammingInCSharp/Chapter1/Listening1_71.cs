using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Note that the code in Listening1_71 also shows that a program can explicity create an instance of the delegate
/// class. The C# compiler will automatically generate the code to create a delegate instance when a method is 
/// assigned to the delegate variable.
/// 
/// </summary>
namespace ProgrammingInCSharp
{
    class Listening1_71
    {
        delegate int IntOperation(int a, int b);

        static int Add(int a, int b)
        {
            Console.WriteLine("Add called");
            return a + b;
        }

        static int Substract(int a, int b)
        {
            Console.WriteLine("Substract called");
            return a - b;
        }

        public static void Listening1_71Main()
        {
            // Explicitly create the delegate
            var op = new IntOperation(Add);
            Console.WriteLine(op(2, 2));

            // Delegate is created automatically
            // from method
            op = Substract;
            Console.WriteLine(op(2, 2));
            Console.ReadKey();
        }
    }
}
