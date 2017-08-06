using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine(" Task *");
                }
            });

            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine(" Main *");
            }

            t.Wait();
            Console.ReadKey();
        }
    }
}
