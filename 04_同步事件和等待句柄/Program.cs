using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_同步事件和等待句柄
{
    class Program
    {
        //同步事件
        private static AutoResetEvent waithandle = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.Write("主线程开始:");
            Thread t = new Thread(DoWork);
            t.Start();
            waithandle.WaitOne();//等待waitHandle
            Console.Write("主线程结束.");Console.ReadKey();
        }
        public static void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");Thread.Sleep(100);
            }
            waithandle.Set();//设置waitHandle
        }

    }
}
