using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_显式创建和运行任务
{
    class Program
    {
        static void Main(string[] args)
        {
            Task taskA = new Task(() => Console.WriteLine("Hello From TaskA."));
            taskA.Start();
            Task taskB = new Task(() => Console.WriteLine("Hello From taskB."));
            Task taskC = new Task(() => Console.WriteLine("Hello From taskC."));
            Console.ReadKey();
        }
    }
}
