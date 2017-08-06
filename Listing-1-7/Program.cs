using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Workingona thread from threadpool");
            });

            Console.ReadKey();
        }
    }
}
