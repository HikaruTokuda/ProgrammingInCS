using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp
{
    class Listening1_77
    {
        public static void Listening1_77Main()
        {
            try
            {
                Console.Write("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result;
                result = int.Parse(numberText);
                Console.WriteLine("You enterd {0}", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Stacktrace: " + ex.StackTrace);
                Console.WriteLine("HelpLink: " + ex.HelpLink);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine("Source: " + ex.Source);
            }
            Console.ReadKey();
        }
    }
}
