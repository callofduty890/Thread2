using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Task常用操作
{
    class Program
    {
        static void Main(string[] args)
        {

         Task taskA = new Task(() => { 
            Console.WriteLine("taskA开始...");
            Thread.Sleep(5000);//模拟工作过程
                                                        });
            //启动
            taskA.Start();
            //执行完成后的任务
            taskA.ContinueWith((t) => {
                Console.WriteLine("任务完成,完成时候的状态为：");
                Console.WriteLine("IsCanceled={0};IsCompleted={1};IsFaulted={2}", t.IsCanceled, t.IsCompleted, t.IsFaulted);
            });
            Console.ReadKey();//等待输入

        }
    }
}
