using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Format strings
/// ①5桁左寄せ 10進数
/// ②10桁左寄せ16進数
/// ③5桁右寄せ小数第2位まで
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class Listening2_72
    {
        public static void Listening2_72Main()
        {
            int i = 99;
            double pi = 3.141592654;

            Console.WriteLine("{0, -5:D}{0, -10:X}{1, 5:N2}", i, pi);
            Console.ReadKey();
        }
    }
}
