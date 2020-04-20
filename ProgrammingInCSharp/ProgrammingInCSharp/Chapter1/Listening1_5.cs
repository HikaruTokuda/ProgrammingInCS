using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// The AsParallel method examines the query to determine if using parallel version would speed it up.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_5
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }


        public static void Listening1_5Main()
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

            var result = from person in people.AsParallel()
                         where person.City == "Seattle"
                         select person;

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();

        }
    }
}
