using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;



/// <summary>
/// some .NET exception types contain lists of inner exceptions.These are called "agregate exceptions."
/// They occur when more than one thing can fail as operation is performed, or when the result of a series 
/// of actions need to be nrought together.
/// </summary>
namespace ProgrammingInCSharp
{
    class Listening1_84
    {
        async static Task<string> FetchWebPage(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            return await response.Content.ReadAsStringAsync();
        }

        public static void Listening1_84Main()
        {
            try
            {
                Task<string> getpage = FetchWebPage("invalid uri");
                getpage.Wait();
                Console.WriteLine(getpage.Result);
            }
            catch (AggregateException ag)
            {
                foreach (Exception e in ag.InnerExceptions)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
