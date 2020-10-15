using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_并行处理Parallel
{
    class Program
    {
        public static void DoWork1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1-{0}\n", i);Thread.Sleep(100);
            }
        }
        public static void DoWork2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("2-{0}\n", i); Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Parallel.Invoke(DoWork1, DoWork2);
            Console.ReadKey();
        }
    }
}
