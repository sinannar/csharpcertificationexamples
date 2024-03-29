﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(0); Console.WriteLine("1"); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(0); Console.WriteLine("2"); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(0); Console.WriteLine("3"); return 3; });

            Task.WaitAll(tasks);

            Console.ReadKey();
        }
    }
}
