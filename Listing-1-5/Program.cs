

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Listing_1_5
{
    class Program
    {
        //[ThreadStatic]
        public static int _field;

        static void Main(string[] args)
        {
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread A: {_field}");
                }
            }).Start();

            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
