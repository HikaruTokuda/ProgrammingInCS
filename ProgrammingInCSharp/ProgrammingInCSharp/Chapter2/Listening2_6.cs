using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Generic Types
/// Listening2_6 shows how genericc can be used to create a stack type that can be used to hold a stack 
/// of any type of object.
/// 
/// Generic constraints
/// Listening2_6 can hold any type of data. If you want to restrict it to only store reference types you can
/// add a constraint on the possible types that T can represent.
/// The MyStack declaration  restricts the stack to holding reference types, so it isn't now possible to store
/// integers in the stack.
/// 
/// class MyStack<T> where T: class
/// 
/// where T: class -> The type T must be a reference type.
/// where T: struct -> The type T must be a value type.
/// where T: new() -> The type T must have a public, parameterless, constructor.Specify this constraint last
///                   if you are specifying a list of constraunts.
/// where T: <base class> -> The type T must be of type base class or derive from base class.
/// where T: <interface name> -> The type T must be or implement the specified interface.You can specify multipul interfaces.
/// where T: unmanaged -> The type T must not be a reference type or  contain any members which are reference types.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_6
    {
        class MyStack<T>
        {
            int stackTop = 0;
            T[] items = new T[100];

            public void Push(T item)
            {
                if (stackTop == items.Length)
                    throw new Exception(string.Format("Stack full. TOP: {0} LENGTH: {1}", stackTop, items.Length));
                items[stackTop] = item;
                stackTop++;
            }

            public T Pop()
            {
                if (stackTop == 0)
                    throw new Exception(string.Format("Stack empty. TOP: {0}", stackTop));
                stackTop--;
                return items[stackTop];
            }
        }

        static public void Listening2_6Main()
        {
            MyStack<string> nameStack = new MyStack<string>();

            nameStack.Push("Rob");
            nameStack.Push("Mary");
            Console.WriteLine(nameStack.Pop());
            Console.WriteLine(nameStack.Pop());

            Console.ReadKey();
        }
    }
}
