using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Static variables
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_11
    {
        class Alien5
        {
            public static int Max_Lives = 99;

            public int X;
            public int Y;
            public int Lives;

            public Alien5(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid position");

                if (lives > Max_Lives)
                    throw new Exception("Invalid lives");

                X = x;
                Y = y;
                Lives = lives;
            }

            public override string ToString()
            {
                return string.Format("X : {0}  Y : {1}  Lives : {2}", X, Y, Lives);
            }
        }

        public static void Listening2_11Main()
        {
            Alien5.Max_Lives = 150;
            Alien5 x = new Alien5(100, 100, 100);
            Console.WriteLine("x : {0}", x);
            Console.ReadKey();
        }
    }
}
