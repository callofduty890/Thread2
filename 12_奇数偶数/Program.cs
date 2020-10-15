using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_奇数偶数
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadWorkTest thread = new ThreadWorkTest();

            Thread th1 = new Thread(thread.PrintOdd);
            th1.Name = "奇数";

            Thread th2 = new Thread(thread.PrintEven);
            th2.Name = "偶数";

            th1.Start();
            th2.Start();

            Console.ReadKey();
        }
    }

    public class ThreadWorkTest
    {
        //创建同步事件
        private static AutoResetEvent odd = new AutoResetEvent(false);
        private static AutoResetEvent even = new AutoResetEvent(false);


        public void PrintOdd()
        {
            odd.WaitOne();
            for (int i = 0; i < 100; i++)
            {
                if (i%2 != 1)continue;
                Console.WriteLine("{0}:{1}", Thread.CurrentThread.Name, i);
                even.Set();
                odd.WaitOne();
            }
        }
        public void PrintEven()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)continue;
                Console.WriteLine("{0}:{1}", Thread.CurrentThread.Name, i);
                odd.Set();
                even.WaitOne();
            }
        }
    }

}
