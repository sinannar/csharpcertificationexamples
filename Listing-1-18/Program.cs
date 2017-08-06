using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Listing_1_18
{
    class Program
    {
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }

        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
