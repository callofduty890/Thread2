using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task返回值
{
    class Program
    {
        static void Main(string[] args)
        {

            var t = Task<double>.Factory.StartNew(() => {
                
                return Math.Pow(2,4) ;
            });
            Console.WriteLine("2的4次方为{0}",t.Result);
            Console.ReadKey();
        }
    }
}
