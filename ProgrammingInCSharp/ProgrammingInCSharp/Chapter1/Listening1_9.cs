using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// The ForAll method can be used to iterate through all of the elements in a query.
/// it differs from the foreach C# construction in that the iteration takes place in parallel and will start before the query
/// is complete.
/// the parallel nature of the excution of FarAll means that the order of printed output above will not reflect ordering of
/// the input data.
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_9
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        public static void Listening1_9Main()
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
            result.ForAll(person => Console.WriteLine(person.Name));

            Console.WriteLine("Finish Processing.");
            Console.ReadKey();

        }
    }
}
