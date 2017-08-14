using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_19
{
    class Program
    {
        public static async Task SleepAsyncA(int milliseconds)
        {
            await Task.Run(() => Thread.Sleep(milliseconds));
            Console.WriteLine("AAA");

        }

        public static Task SleepAsyncB(int milliseconds)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(milliseconds, -1);
            return tcs.Task;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //SleepAsyncA(1000);

            Console.WriteLine("AAA");
            Console.ReadKey();
        }
    }
}
