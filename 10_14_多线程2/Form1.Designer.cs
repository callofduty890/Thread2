namespace _10_14_多线程2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.Therad_label_1 = new System.Windows.Forms.Label();
            this.Therad_label_2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.Therad_label_3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.Therad_label_4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.Therad_label_5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 19F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "线程1:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(145, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 33);
            this.progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "启 动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 19F);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "线程2:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(145, 78);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(544, 33);
            this.progressBar2.TabIndex = 1;
            // 
            // Therad_label_1
            // 
            this.Therad_label_1.AutoSize = true;
            this.Therad_label_1.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_label_1.Location = new System.Drawing.Point(716, 24);
            this.Therad_label_1.Name = "Therad_label_1";
            this.Therad_label_1.Size = new System.Drawing.Size(47, 33);
            this.Therad_label_1.TabIndex = 3;
            this.Therad_label_1.Text = "0%";
            // 
            // Therad_label_2
            // 
            this.Therad_label_2.AutoSize = true;
            this.Therad_label_2.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_label_2.Location = new System.Drawing.Point(716, 78);
            this.Therad_label_2.Name = "Therad_label_2";
            this.Therad_label_2.Size = new System.Drawing.Size(47, 33);
            this.Therad_label_2.TabIndex = 3;
            this.Therad_label_2.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 19F);
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "线程3:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(145, 130);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(544, 33);
            this.progressBar3.TabIndex = 1;
            // 
            // Therad_label_3
            // 
            this.Therad_label_3.AutoSize = true;
            this.Therad_label_3.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_label_3.Location = new System.Drawing.Point(716, 130);
            this.Therad_label_3.Name = "Therad_label_3";
            this.Therad_label_3.Size = new System.Drawing.Size(47, 33);
            this.Therad_label_3.TabIndex = 3;
            this.Therad_label_3.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 19F);
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "线程4:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(145, 181);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(544, 33);
            this.progressBar4.TabIndex = 1;
            // 
            // Therad_label_4
            // 
            this.Therad_label_4.AutoSize = true;
            this.Therad_label_4.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_label_4.Location = new System.Drawing.Point(716, 181);
            this.Therad_label_4.Name = "Therad_label_4";
            this.Therad_label_4.Size = new System.Drawing.Size(47, 33);
            this.Therad_label_4.TabIndex = 3;
            this.Therad_label_4.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 19F);
            this.label9.Location = new System.Drawing.Point(12, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "线程5:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(145, 237);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(544, 33);
            this.progressBar5.TabIndex = 1;
            // 
            // Therad_label_5
            // 
            this.Therad_label_5.AutoSize = true;
            this.Therad_label_5.Font = new System.Drawing.Font("宋体", 19F);
            this.Therad_label_5.Location = new System.Drawing.Point(716, 237);
            this.Therad_label_5.Name = "Therad_label_5";
            this.Therad_label_5.Size = new System.Drawing.Size(47, 33);
            this.Therad_label_5.TabIndex = 3;
            this.Therad_label_5.Text = "0%";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(186, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "线程挂起";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(359, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "线程终止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(535, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 55);
            this.button4.TabIndex = 2;
            this.button4.Text = "清空进度条";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.Therad_label_5);
            this.Controls.Add(this.Therad_label_4);
            this.Controls.Add(this.Therad_label_3);
            this.Controls.Add(this.Therad_label_2);
            this.Controls.Add(this.Therad_label_1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label Therad_label_1;
        private System.Windows.Forms.Label Therad_label_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label Therad_label_3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label Therad_label_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label Therad_label_5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

