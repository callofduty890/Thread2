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
        Thread[] Threads = new Thread[6];//创建线程数组
        //启动线程
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                ProgressBar progressBar = (ProgressBar)this.Controls.Find("progressBar"+i.ToString(), false).FirstOrDefault();

                Label label = (Label)this.Controls.Find("Therad_label_" + i.ToString(), false).FirstOrDefault();

                Threads[i-1] = new Thread(()=>Method(progressBar, label));
                Threads[i-1].IsBackground = true;//设置成后台线程
                Threads[i-1].Start();
            }


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
        //线程挂起
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "线程挂起")
            {
                for (int i = 0; i < Threads.Length-1; i++)
                {
                    Threads[i].Suspend();//过时的方法 自己构建Do循环可以替代
                }
                this.button2.Text = "线程唤醒";
            }
            else
            {
                for (int i = 0; i < Threads.Length-1; i++)
                {
                    Threads[i].Resume();//过时的方法
                }
                this.button2.Text = "线程挂起";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Threads.Length-1; i++)
            {
                Threads[i].Abort();//终止线程
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                ProgressBar progressBar = (ProgressBar)this.Controls.Find("progressBar" + i.ToString(), false).FirstOrDefault();
                Label label = (Label)this.Controls.Find("Therad_label_" + i.ToString(), false).FirstOrDefault();
                progressBar.Value = 0;
                label.Text = "0%";
            }
        }
    }
}
