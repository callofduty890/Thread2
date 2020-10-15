using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_线程池
{
    class Program
    {
        public static void DoWork(object state)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}-{1}", state.ToString(), i);
                Thread.Sleep(100);//模拟实际操作 TASK
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, "线程" + i);
            }
            Console.ReadKey();
        }
    }
}
