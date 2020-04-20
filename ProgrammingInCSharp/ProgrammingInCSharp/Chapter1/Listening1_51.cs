using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Consider the class Counter in Listening1_51.It is intended to be used to collect values and add them
/// to a total value that can then be read by users of the object.
/// It works well in a single thread.In an application that uses multiple tasks, however, it fails in the same way as
/// the program show in Listening1_42,
/// If several tasks make use of the IncreaseCounter method at the same time,
/// race conditions causes updates to totalValue to be overwritten.m
/// </summary>
namespace ProgrammingInCSharp
{
    class Counter
    {
        private int totalValue = 0;

        public void IncreaseCounter(int amount)
        {
            totalValue = totalValue + amount;
        }

        public int Total
        {
            get { return totalValue; }
        }
    }


    class Listening1_51
    {
        public static void Listening1_51Main()
        {

        }
    }
}
