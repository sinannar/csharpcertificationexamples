using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_17
{
    class Program
    {
        static void Main(string[] args)
        {
            long? LowestBreakIteration = new long?();
            bool isStopped = new bool();
            ParallelLoopResult result = Parallel.For(0, 100, (int i, ParallelLoopState loopState) => {
                Console.WriteLine(i);
                if (i == 50)
                {
                    Console.WriteLine("Breaking loop...");
                    loopState.Stop();
                    LowestBreakIteration = loopState.LowestBreakIteration;
                    isStopped = loopState.IsStopped;
                }
            });
            Console.WriteLine("==========>" + (LowestBreakIteration.HasValue ? LowestBreakIteration.Value.ToString() : ""));
            Console.WriteLine("==========>" + isStopped.ToString());
            Console.ReadKey();

            return;
        }
    }
}
