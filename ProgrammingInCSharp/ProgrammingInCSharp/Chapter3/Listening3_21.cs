using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Checksums
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_21
    {

        static int calculateChecksum(string source)
        {
            int total = 0;
            foreach (char ch in source)
            {
                total = total + (int)ch;
            }
            return total;
        }

        static void showChecksum(string source)
        {
            Console.WriteLine("Checksum for {0} is {1}", source, calculateChecksum(source));
        }

        static void ShowHash(string source)
        {
            Console.WriteLine("Hash for {0} is {1:X}", source, source.GetHashCode());
        }

        public static void Listening3_21Main()
        {
            ShowHash("Hello world");
            ShowHash("world Hello");
            ShowHash("Hemmm world");

            Console.ReadKey();
        }
    }
}
