using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// The query in Listening1-8 retrieves the names of the first four people who live in Seattle.
/// The query requests that the result be ordered by person name, and its ordering preserved by the use of AsSequential before
/// the Take, whichi removes the four people.
/// if the Take is excuted in parallel it can disrupt ordering of the result.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_8
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        public static void Listening1_8Main()
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

            var result = (from person in people.AsParallel()
                          where person.City == "Seattle"
                          orderby (person.Name)
                          select new
                          {
                              Name = person.Name
                          }).AsSequential().Take(4);

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Finish Processing.");
            Console.ReadKey();

        }
    }
}
