using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Creating reference types
/// Note that when a variable of type Alien is declared, the variable is now reference to an Alien,
/// and initially the referencedoes not refer ti anything.When we created the swarm we had to wxplicity set 
/// each element in the array to refer to an Alien instance.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    /// <summary>
    /// Memory allocation
    /// Memory to be used to store variables of value type is allocated on the "stack".
    /// The stack is an area of memory that is allocated and removed as programs enter and leave blocks.
    /// Memory to be used to store variables of reference type is allocated on a different structure, called
    /// "heap". The heap is managed for an entire application. The heap is required because, as references may 
    /// be passed between method calls as parameters, it is not the case be removed from the heap when the garbage
    /// collection process determines that there are no references to them.
    /// </summary>
    class Alien2
    {
        public int X;
        public int Y;
        public int Lives;

        public Alien2(int x, int y)
        {
            X = x;
            Y = y;
            Lives = 3;
        }

        public override string ToString()
        {
            return string.Format("X: {0}  Y: {1}  Lives: {2}", X, Y, Lives);
        }
    }

    class Listening2_5
    {
        public static void Listening2_5Main()
        {
            Alien2 x = new Alien2(100, 100);
            Console.WriteLine("x {0}", x.ToString());

            Alien2[] swarm = new Alien2[100];
            for(int i = 0; i < swarm.Length; i++)
                Console.WriteLine("swarm[0] {0}", swarm[i].ToString());

            Console.WriteLine("swarm[0] {0}", swarm[0].ToString());
            Console.ReadKey();
        }
    }
}
