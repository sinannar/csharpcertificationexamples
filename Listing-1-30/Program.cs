using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_30
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(2);
            bag.Add(4);

            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);
            if (bag.TryTake(out result))
                Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
