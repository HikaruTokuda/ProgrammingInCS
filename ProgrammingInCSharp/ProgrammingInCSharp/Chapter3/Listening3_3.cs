using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

/// <summary>
/// Validating JSON
/// The JSON text text in Listening3_3 contains a missing double quote character before the value of the Length property.
/// If you run this program you will see the following output meassage. Note that exception also contains integer version of line and position values identified in the
/// outpur text.
/// Unexpected character encountered while parsing number: ". Path 'Length', line 1, position 52.
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class Listening3_3
    {
        public static void Listening3_3Main()
        {
            string invalidJson = "{\"Artist\":\"Rob Miles\", \"Title\":\"My Way\",\"Length\":150\"}";

            try
            {
                MusicTrack3_2 trackRead = JsonConvert.DeserializeObject<MusicTrack3_2>(invalidJson);

                Console.WriteLine("Read back: ");
                Console.WriteLine(trackRead);
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
