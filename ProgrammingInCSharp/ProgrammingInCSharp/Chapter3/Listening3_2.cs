using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

/// <summary>
/// Creating XML.
/// There are a few things you need to be aware of when considering JSON and XML.
/// ・XML serialization can only save and load the public data elements in a type. If you want to save the private elements in a class you should use the Data Contract serializer
///   described in Chapter4.
/// ・For XML serialization to work the class being serialized mustcontain a parameterless constructor(a constructor that accepts no parameters)
/// ・The XML deserialization process returns a reference to an object. n Listening3_2 this reference is cast into a MusicTrack.
/// ・XML documents can have a schema attached to them. A schema formally sets out the items that a document must contain to be valid.For example, for the MusicTrack type the scheme can 
///   require that MusicTrack elements in the document must contain Artist, Title, and Length elements.
/// ・Elements in an XML document can also begiven attributes to provide more information about them. For example, the Length attribute of a MusicTrack can be given attribute to indicate that
///   it is an integer and the units of the value are in seconds.
/// ・An XML document is no less vulnerable to tampering than JSON document.However, the attribute mechanism can be used to add validation information to data fields.
/// </summary>
namespace ProgrammingInCSharp.Chapter3
{

    public class MusicTrack3_2
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return Artist + " " + Title + " " + Length.ToString() + "second long  ";
        }

        public MusicTrack3_2(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
        }

        /// <summary>
        /// Parameterless constructor required by the XML serializer.
        /// Does not need to set any property values, these are public.
        /// </summary>
        public MusicTrack3_2()
        {
        }
    }


    class Listening3_2
    {
        public static void Listening3_2Main()
        {
            MusicTrack3_2 track = new MusicTrack3_2(artist: "Rob Miles", title: "My Way", length: 150);
            XmlSerializer musicTrackSerializer = new XmlSerializer(typeof(MusicTrack3_2));
            TextWriter serWriter = new StringWriter();

            musicTrackSerializer.Serialize(textWriter: serWriter, o: track);
            serWriter.Close();

            string trackXML = serWriter.ToString();

            Console.WriteLine("Track XML");
            Console.WriteLine(trackXML);

            TextReader serReader = new StringReader(trackXML);
            MusicTrack3_2 trackRead = musicTrackSerializer.Deserialize(serReader) as MusicTrack3_2;

            Console.WriteLine("Reaad back: ");
            Console.WriteLine(trackRead);

            Console.ReadKey();
        }
    }
}
