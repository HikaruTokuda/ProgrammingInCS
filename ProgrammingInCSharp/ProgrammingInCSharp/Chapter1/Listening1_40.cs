using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

/// <summarys>
/// The TryAdd method tries to add new item.If the item already exist, the TryAdd method returns false.
/// 
/// </summary>
namespace ProgrammingInCSharp.Chapter1
{
    class Listening1_40
    {
        public static void Listening1_40Main()
        {
            ConcurrentDictionary<string, int> ages = new ConcurrentDictionary<string, int>();
            if (ages.TryAdd("Rob", 21))
                Console.WriteLine("Rob added sucessfully.");
            Console.WriteLine("Rob's age: {0}", ages["Rob"]);

            // Set Rob's age to 22 if it is 21
            if (ages.TryUpdate("Rob", 22, 21))
                Console.WriteLine("Age updated sucessfuly.");
            Console.WriteLine("Rob's age: {0}", ages["Rob"]);

            // Increment Rob's age atomatically using factory method
            Console.WriteLine( "Rob's age updated to: {0}", 
                ages.AddOrUpdate("Rob", 1, (name, age) => age = age + 1 ));

            // Tokuda's Test
            // 第3引数はすでに存在したときだけ実行される。無かったら第1引数をKeyに、第2引数をValueにして新規追加
            ages.AddOrUpdate("Ben", 3, (name, age) => age = age + 1);

            Console.WriteLine("Rob's new age: {0}", ages["Rob"]);

            foreach (var age in ages.Keys)
            {
                Console.WriteLine("name: {0}  age: {1}", age, ages[age]);
            }

            Console.ReadKey();
        }
    }
}
