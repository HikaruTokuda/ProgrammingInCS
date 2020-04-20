using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Optional and named parameters
/// When you create a amethod with parameters, the signature of the method gives the name and type of each parameters
/// in turn.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_14
    {
        public static void Listening2_14Main()
        {
            Console.WriteLine(ReadValue(data1: 1, data2: 2, data3: 3));
            Console.ReadKey();
        }

        static int ReadValue(int data1, int data2, int data3)
        {
            return data1 + data2 + data3;
        }
    }
}
