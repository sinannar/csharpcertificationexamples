using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 1010);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).AsSequential().ToArray();

            foreach (var item in parallelResult)
            {

                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
