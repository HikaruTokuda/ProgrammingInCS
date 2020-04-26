using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{

    class Person2_63
    {
        long[] personArray = new long[1000000];
    }

    class Listening2_63
    {
        public static void Listening2_63Main()
        {
            for (long i = 0; i < 100000000000; i++)
            {
                Person2_63 p = new Person2_63();
                System.Threading.Thread.Sleep(3);
            }
        }
    }
}
