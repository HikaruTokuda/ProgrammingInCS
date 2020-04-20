using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Indexed properties
/// A program can access a aparticular array element by using an index value that identifies the
/// element.
/// A class can use the same indexing mechanism to provide indexed propertiy values.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class IntArrayWrapper
    {
        // create an array to store the values
        private int[] array = new int[100];

        // Declare an indexer property
        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    class NamedIntArray
    {
        // create  an array to store the values
        private int[] array = new int[100];

        // Declare an indexer properties
        public int this[string name]
        {
            get
            {
                switch (name)
                {
                    case "zero":
                        return array[0];
                    case "one":
                        return array[1];
                    default:
                        return -1;
                }
            }

            set
            {
                switch (name)
                {
                    case "zero":
                        array[0] = value;
                        break;
                    case "one":
                        array[1] = value;
                        break;
                }
            }
        }
    }

    class Listening2_16
    {
        public static void Listening2_16Main()
        {
            IntArrayWrapper x = new IntArrayWrapper();
            x[0] = 99;
            Console.WriteLine(x[0]);

            NamedIntArray y = new NamedIntArray();
            y["zero"] = 10;
            Console.WriteLine(y["zero"]);
            Console.ReadKey();
        }
    }
}
