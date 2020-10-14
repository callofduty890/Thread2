using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_14_多线程2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //关闭跨线程访问限制
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        //启动线程
        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    this.progressBar1.Value = i;
            //}
            Thread t1 = new Thread(()=>Method(this.progressBar1,this.Therad_label_1));
            t1.Start();
            Thread t2 = new Thread(() => Method(this.progressBar2, this.Therad_label_2));
            t2.Start();
        }

        //线程的方法
        public void Method(ProgressBar progressBar,Label label)
        {
            for (int i = 0; i <= 100; i++)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar.Value = i;
                    label.Text = i.ToString()+"%";
                }));
               Thread.Sleep(50);
            }
        }

    }
}
