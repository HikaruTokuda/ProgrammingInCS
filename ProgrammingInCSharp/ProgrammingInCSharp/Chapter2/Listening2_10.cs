using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Static constructors
/// A class can contain static construtor method. This is called once before the creation of the very first
/// instance if the class.
/// The Alien4 class in  Listening2_10 contains  a static constructor that prints a message when it is called.
/// When the program runs, the message is printedonce, before the first alien created. The second constructor
/// is not called when the second alien is created.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_10
    {
        class Alien4
        {
            public int X;
            public int Y;
            public int Lives;

            public override string ToString()
            {
                return string.Format("X : {0}  Y : {1}  Lives : {2}", X, Y, Lives);
            }

            public Alien4(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid position");

                X = x;
                Y = y;
                Lives = lives;
            }

            public Alien4(int x, int y) : this(x, y, 3)
            {
            }

            static Alien4()
            {
                Console.WriteLine("Static Alien constructor runnning.");
            }
        }

        public static void Listening2_10Main()
        {
            
            Alien4[] x = { new Alien4(100, 100), new Alien4(99, 99), new Alien4(98, 98)};
            foreach (var alien in x)
            {
                Console.WriteLine("alien : {0}", alien);
            }            
            Console.ReadKey();
        }
    }
}