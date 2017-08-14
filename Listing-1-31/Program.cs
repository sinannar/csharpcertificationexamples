using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_31
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task.Run(() =>
            {
                bag.Add(4);
                Thread.Sleep(1000);
                bag.Add(7);
            });

            Task.Run(() =>
            {
                foreach (var item in bag)
                {
                    Console.WriteLine(item);
                }
            }).Wait();
            Console.ReadKey();
        }
    }
}
