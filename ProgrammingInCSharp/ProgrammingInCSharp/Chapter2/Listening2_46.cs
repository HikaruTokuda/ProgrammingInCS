using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/// <summary>
/// The Serializable attribute
/// </summary>
namespace ProgrammingInCSharp
{
    [Serializable]
    public class Person
    {
        public string Name;
        public int Age;

        [NonSerialized]
        // No need to save this
        private int screenPosition;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            screenPosition = 0;
        }

        public override string ToString()
        {
            return string.Format($"Name: {Name}  age: {Age}  screenPosition: {screenPosition}");
        }
    }

    class Listening2_46
    {
        public static void Listening2_46Main()
        {
            Person person = new Person("NAME", 100);
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
