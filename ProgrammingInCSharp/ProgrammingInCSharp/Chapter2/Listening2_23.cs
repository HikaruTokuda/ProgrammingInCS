using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Convert Types
/// The .NET runtime provides a set of conversion methods that are used to perform casting.
/// You can also write your own type conversions between types.
/// The type Miles contains a double precision distance value in the property Distance.The  Miles class
/// also contains an implict called kilometers, which returns a value of type Kilometers, representing the
/// same distance.A program can then assign a variable of type Miles value into a variable of type Kilometers.
/// During the assignment the implict conversion operator is called automatically.
/// The type Miles also contains an explicit conversion that returns the distance value as an integer.
/// This conversion is explicit because it is narrowing operation that will result in aloss of data, as the
/// fractional part of the double precision distance value is truncated.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Miles
    {
        public double Distance { get; }

        // Conversion operator for implict conversion to kilometers
        public static implicit operator Kilometers(Miles t)
        {
            Console.WriteLine("Implict conversion from miles to kilometers");
            return new Kilometers(t.Distance * 1.6);
        }

        public static explicit operator int(Miles t)
        {
            Console.WriteLine("Explict conversion from miles to int");
            return (int)(t.Distance + 0.5);
        }

        public Miles(double miles)
        {
            Distance = miles;
        }
    }

    class Kilometers
    {
        public double Distance { get; }

        public Kilometers(double kilometers)
        {
            Distance = kilometers;
        }
    }

    class Listening2_23
    {
        public static void Listening2_23Main()
        {
            Miles m = new Miles(100);

            Kilometers k = m; // implicity convert miles to km
            Console.WriteLine("Kilometers: {0}", k.Distance);

            int intMiles = (int)m; // Explicity convert miles to int
            Console.WriteLine("Int miles: {0}", intMiles);

            Console.ReadKey();
        }


    }
}
