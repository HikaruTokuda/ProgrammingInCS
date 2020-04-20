using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Enforce encapsulation by using explicit interface implemention.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    interface IPrintable
    {
        string GetPrintableText(int pageWidth, int pageHeight);
        string GetTitle();
    }

    interface IDisplay
    {
        string GetTitle();
    }

    class Report : IPrintable, IDisplay
    {
        string IPrintable.GetPrintableText(int pageWidth, int pageHeight)
        {
            return "Report text to be printed.";
        }

        string IPrintable.GetTitle()
        {
            return "Report title to be printed.";
        }

        string IDisplay.GetTitle()
        {
            return "Report title to be displayed.";
        }
    }

    class Listening2_32
    {
        public static void Listening2_32Main()
        {
            Report report = new Report();
            IPrintable printItem = report;
            Console.WriteLine(printItem.GetPrintableText(0, 0));
            Console.WriteLine(printItem.GetTitle());

            IDisplay displayItem = report;
            Console.WriteLine(displayItem.GetTitle());

            Console.ReadKey();
        }
    }
}
