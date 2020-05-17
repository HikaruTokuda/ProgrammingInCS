using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStrage;

namespace LISTENING_3_25_Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyName = typeof(MusicTrack).Assembly.FullName;

            Console.WriteLine(assemblyName);
            Console.ReadKey();
        }
    }
}
