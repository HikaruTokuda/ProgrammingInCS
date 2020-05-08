using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


/// <summary>
/// JSON and C#
/// Newtonsoft tutorial.
/// When you start to use JSON in your programs there are a few things that you need to be aware of from a security and class design point of view:
/// ・If you want to save and load private properties in a class you need to make these items with the [JsonProperty] attribute.
/// ・If you want to serialize a aclass using JSON you don't have to add the [Serializable] attribute to the class.You can find outmore about serialization in Skill 2.5 in 
///   "The Serializable attribute" section.
/// ・When loading a class back using JSON you need to provide the type into which the result is to be stored.No type information is stored in the file that is stored.
///   The Length property of the MuscTrack is automatically converted into an integer upon reloading because of the JSON desirializer determines the type of each property in
///   in the destination object and then performs type conversion automatically. This is a nice example of the use of the reflection techniques shown in Skill 2.5.
/// ・There is absolutely nothing to prevent changes to the content of the text in aJSON document. If you wish to detect modification of a adocument transferred by JSON you can add 
///   a checksum or hash property to the type that  is validated by the recipient of the data. In hte next section we will look at encryption techniques you can use to securely send data.
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class MusicTrack3_1
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        private string PrivateData;
        [JsonProperty]
        private string PrivateDataWithAttribute;

        public override string ToString()
        {
            return Artist + " " + Title + " " + Length.ToString() + "second long  " + "Private: " + PrivateData + "  WithAttribute: " + PrivateDataWithAttribute;
        }

        public MusicTrack3_1(string artist, string title, int length, string privateData, string withAttribute)
        {
            Artist = artist;
            Title = title;
            Length = length;
            PrivateData = privateData;
            PrivateDataWithAttribute = withAttribute;
        }


    }


    class Listening3_1
    {
        public static void Listening3_1Main()
        {
            MusicTrack3_1 track = new MusicTrack3_1(artist: "Rob Miles", title: "My Way", length: 150, privateData: "Private", withAttribute: "WithAttribute");

            string json = JsonConvert.SerializeObject(track);
            Console.WriteLine("JSON: ");
            Console.WriteLine(json);

            MusicTrack3_1 trackRead = JsonConvert.DeserializeObject<MusicTrack3_1>(json);
            Console.WriteLine("Read back: ");
            Console.WriteLine(trackRead);

            List<MusicTrack3_1> album = new List<MusicTrack3_1>();
            string[] trackNames = new[] { "My Way", "Your Way", "Their Way", "The Wrong Way" };
            foreach (string trackName in trackNames)
            {
                MusicTrack3_1 newTrack = new MusicTrack3_1(artist: "Rob Miles", title: trackName, length: 150, privateData: "Private", withAttribute: "WithAttribute");
                album.Add(newTrack);
            }

            string jsonArray = JsonConvert.SerializeObject(album);
            Console.WriteLine("JSON: ");
            Console.WriteLine(jsonArray);


            List<MusicTrack3_1> albumRead = JsonConvert.DeserializeObject<List<MusicTrack3_1>>(jsonArray);
            Console.WriteLine("Read back: ");
            foreach (MusicTrack3_1 readTrack in albumRead)
            {
                Console.WriteLine(readTrack);
            }

            Console.ReadKey();
        }

    }
}
