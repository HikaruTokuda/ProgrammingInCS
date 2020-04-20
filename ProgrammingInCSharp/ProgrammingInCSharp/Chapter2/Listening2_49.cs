using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Creating attribute classes.
/// It shows how to create attribute classes CreateAttributeClasses.cs in PlayGround project
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class ProgrammerAttribute : Attribute
    {
        private string programmerValue;

        public ProgrammerAttribute(string programmer)
        {
            programmerValue = programmer;
        }

        public string Programmer
        {
            get { return programmerValue; }
        }
    }

    class Listening2_49
    {
    }
}
