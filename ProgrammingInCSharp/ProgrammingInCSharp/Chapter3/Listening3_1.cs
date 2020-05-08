using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


/// <summary>
/// JSON and C#
/// Newtonsoft tutorial.
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{
    class MusicTrack3_1
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return Artist + " " + Title + " " + Length.ToString() + "second long";
        }

        public MusicTrack3_1(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }


    }


    class Listening3_1
    {
        public static void Listening3_1Main()
        {
            MusicTrack3_1 track = new MusicTrack3_1(artist: "Rob Miles", title: "My Way", length: 150);

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
                MusicTrack3_1 newTrack = new MusicTrack3_1(artist: "Rob Miles", title: trackName, length: 150);
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
