using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_26
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0,20);
            var parallel = numbers.AsParallel().Where(x => x % 2 == 0);

            parallel.ForAll(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
