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

    }
}
