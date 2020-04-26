using System;
using System.Globalization;

namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_74
    {
        public static void Listening2_74Main()
        {
            double bankBalance = 123.45;
            CultureInfo usProvider = new CultureInfo("en-US");
            Console.WriteLine("US balance: {0}", bankBalance.ToString("C", usProvider));

            CultureInfo ukProvider = new CultureInfo("en-GB");
            Console.WriteLine("UK balance: {0}", bankBalance.ToString("C", ukProvider));

            Console.ReadKey();
        }
    }
}
