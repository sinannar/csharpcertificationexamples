using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(200); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(100); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(300); return 3; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);

                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();

            }

            Console.ReadKey();
        }
    }
}
