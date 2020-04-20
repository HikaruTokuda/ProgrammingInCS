using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Constructors
/// A constructor allows a programmer to control the process by which objects are created.
/// Constructors can be used with value types(structures) and reference types(classes). A constructor has the
/// same name as the object it is part of but does not have a return type.
/// 
/// Constructors can be overloaded, so an object can contain multipul versions of constructor with 
/// different signatures.
/// 
/// A program can avoid code repetition by making one constructor call another constructor by used of the
/// keyword "this." The "this." keyword is used in the constructor method signature as shown Listening2_9.
/// It forms a call of another constructor in the object.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_9
    {
        class Alien3
        {
            public int X;
            public int Y;
            public int Lives;

            public Alien3(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid position");

                X = x;
                Y = y;
                Lives = lives;
            }

            public Alien3(int x, int y) : this(x, y, 3)
            {
            }

            public override string ToString()
            {
                return string.Format("X : {0}  Y : {1}  Lives : {2}", X, Y, Lives);
            }
        }

        public static void Listening2_9Main()
        {
            Alien3 x = new Alien3(100, 100);
            Console.WriteLine("x : {0}", x);
            Console.ReadKey();
        }
    }
}
