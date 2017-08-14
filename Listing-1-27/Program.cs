using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_1_27
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel().Where(x => IsEven(x));

                parallelResult.ForAll(x => Console.WriteLine(x));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"There where {ex.InnerExceptions.Count} exceptions!");
            }

            Console.ReadKey();
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0)
                throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
