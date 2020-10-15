using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_Timer定时器
{
    class Program
    {
        public static void PrintTime(object state)
        {
            Console.WriteLine("{0}  {1}", state.ToString(), DateTime.Now.ToString("HH:MM:ss"));
        }
        static void Main(string[] args)
        {
            //注册时间的回调函数
            TimerCallback timerCallback = new TimerCallback(PrintTime);
            //实例化定时器
            Timer timer1 = new Timer(timerCallback, "timer1", 0, 1000);
            //卡屏显示
            Console.ReadKey();
        }
    }
}
