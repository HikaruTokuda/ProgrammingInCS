using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// The AsOrdered method doesn't prevent the parallelization of the query, instead it organizes
/// the output so that it is the same order as the original data.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_7
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        public static void Listening1_7Main()
        {
            Person[] people = new Person[] {
                new Person{ Name = "Alan", City = "Hull"},
                new Person{ Name = "Beryl", City = "Seattle"},
                new Person{ Name = "Charles", City = "London"},
                new Person{ Name = "David", City = "Seattle"},
                new Person{ Name = "Eddy", City = "Hull"},
                new Person{ Name = "Fred", City = "Berlin"},
                new Person{ Name = "Gordon", City = "Hull"},
                new Person{ Name = "Henry", City = "Seattle"},
                new Person{ Name = "Isaac", City = "Seattle"},
                new Person{ Name = "James", City = "London"},
            };
            var result = from person in people.AsParallel().AsOrdered()
                         where person.City == "Seattle"
                         select person;

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Finish Processing.");
            Console.ReadKey();

        }
    }
}
