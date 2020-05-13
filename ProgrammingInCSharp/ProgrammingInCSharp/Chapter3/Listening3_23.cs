using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/// <summary>
/// SHA2
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_23
    {
        static byte[] calculateHash(string source)
        {
            // This will convert our input string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] sourceBytes = converter.GetBytes(source);

            HashAlgorithm hasher = SHA256.Create();
            byte[] hash = hasher.ComputeHash(sourceBytes);
            return hash;
        }

        static void showHash(string source)
        {
            Console.WriteLine("Hash for {0} is: ", source);

            byte[] hash = calculateHash(source);

            foreach (byte b in hash)
            {
                Console.Write("{0:X} ", b);
            }
            Console.WriteLine();
        }


        public static void Listening3_23Main()
        {
            showHash("Hello world");
            showHash("world Hello");
            showHash("Hemmm world");

            Console.ReadKey();
        }
    }
}
