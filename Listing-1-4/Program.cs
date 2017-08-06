using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                int localVariable = 0;
                while (!stopped)
                {
                    Console.WriteLine($"Running 1 {localVariable++}");
                    Thread.Sleep(0);
                }
            }));

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                int localVariable = 0;
                while (!stopped)
                {
                    Console.WriteLine($"Running 2 {localVariable++}");
                    Thread.Sleep(0);
                }
            }));

            t.Start();
            t2.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
            Console.ReadKey();
        }
    }
}
