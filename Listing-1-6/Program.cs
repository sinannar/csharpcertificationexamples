using System;
using System.Threading;

namespace Listing_1_6
{
    class Program
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() => {
                return Thread.CurrentThread.ManagedThreadId;
            });

        static void Main(string[] args)
        {
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread A:{i}");
                }
            }).Start();
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread B:{i}");
                }
            }).Start();
            Console.ReadKey();
        }
    }
}
