using System;
using System.Reflection;

/// <summary>
/// Use types from the System.Reflection namespace.
/// MthodInfo
/// The MethodInfo class holds data about a method in a type.This includes the signature of the method, the return type of the method, details of method parameters and even
/// the byte code that forms the body of the method.
/// The program Listening2_62 will work through a method and display this information from all the methods in aclass. This code also makes use of the Invoke method
/// from its method information and MethodInvoke to invoke a method from a class.
/// ILとは→https://ufcpp.net/study/il/
/// </summary>
namespace ProgrammingInCSharp
{
    public class Calculator
    {
        public int AddInt(int v1, int v2)
        {
            return v1 + v2;
        }
    }

    class Listening2_62
    {
        public static void Listening2_62Main()
        {
            Console.WriteLine("Get the type information of the Calculator class.");
            Type type = typeof(Calculator);

            Console.WriteLine("Get the method information for the AddInt method.");
            MethodInfo AddIntMethodInfo = type.GetMethod("AddInt");

            Console.WriteLine("Get the IL instructions for AddInt method.");
            MethodBody AddIntMethodBody = AddIntMethodInfo.GetMethodBody();

            // Print the IL instructions.
            foreach (byte b in AddIntMethodBody.GetILAsByteArray())
            {
                Console.WriteLine(" {0:X}", b);
            }
            Console.WriteLine();

            Console.WriteLine("Create Calculator instance.");
            Calculator calc = new Calculator();

            Console.WriteLine("Create parameter array for the method.");
            object[] inputs = new object[] { 1, 2 };

            Console.WriteLine("Call Invoke on the method info.");
            Console.WriteLine("Cast the result to an integer.");
            int result = (int)AddIntMethodInfo.Invoke(calc, inputs);
            Console.WriteLine("Result of: {0}", result);

            Console.WriteLine("Call InvokeMember on the type.");
            result = (int)type.InvokeMember( "AddInt",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null,
                calc,
                inputs );
            Console.WriteLine("Result of: {0}", result);

            Console.ReadKey();
        }
    }
}
