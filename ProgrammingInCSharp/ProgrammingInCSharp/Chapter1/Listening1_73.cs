using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_73
    {
        delegate int GetValue();
        static GetValue getLocalInt;

        static void SetLocalInt()
        {
            // Local variable set to 99
            int localInt = 99;

            // Set delegate getLocalInt to a lambda expression that returns the value of localInt
            getLocalInt = () => localInt;
        }

        public static void Listening1_73Main()
        {
            SetLocalInt();
            Console.WriteLine("Value of localInt {0}", getLocalInt());
            Console.ReadKey();
        }
    }
}
