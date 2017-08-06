using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Listing_1_2
{
    class Program
    {
        public static void ThreadMethod1()
        {
            for (int i = 0; i < 10000000; i++)
            {
                Console.WriteLine("ThreadProc1:{0}", i);
                Thread.Sleep(0);
            }
        }

        public static void ThreadMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc2:{0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(ThreadMethod1));
            Thread t2 = new Thread(new ThreadStart(ThreadMethod2));
            t1.IsBackground = true;
            t2.IsBackground = false;
            t1.Start();
            t2.Start();
            //t1.Join();
            //t2.Join();
            //Console.ReadKey();
        }
    }
}
