using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// the query is excuted on a maximum of four processors.
/// this program's result...
/// Isaac
/// Beryl
/// Henry
/// David
/// Finish Processing.
/// The name "Isaac" is printed first, even though it is not the first name in the source data.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_6
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        public static void Listening1_6Main()
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
            var result = from person in people.AsParallel().
                         WithDegreeOfParallelism(4).
                         WithExecutionMode(ParallelExecutionMode.ForceParallelism)
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
