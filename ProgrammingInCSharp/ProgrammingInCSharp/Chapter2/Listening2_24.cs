using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Handle dynamic types
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class MessageDisplay
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Listening2_24
    {
        public static void Listening2_24Main()
        {
            try
            {
                MessageDisplay m = new MessageDisplay();
                m.DisplayMessage("Hello World.");

                dynamic d = new MessageDisplay();
                d.DisplayMessage("Hello World.");
                d.Banana("Hello World.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

    }
}
