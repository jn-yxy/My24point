namespace Clock
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBrBT = new System.Windows.Forms.RadioButton();
            this.DSrBT = new System.Windows.Forms.RadioButton();
            this.SZrBT1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondNum = new System.Windows.Forms.NumericUpDown();
            this.minuteNum = new System.Windows.Forms.NumericUpDown();
            this.hourNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(120, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 72);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MBrBT);
            this.groupBox1.Controls.Add(this.DSrBT);
            this.groupBox1.Controls.Add(this.SZrBT1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能选择";
            // 
            // MBrBT
            // 
            this.MBrBT.AutoSize = true;
            this.MBrBT.Location = new System.Drawing.Point(333, 19);
            this.MBrBT.Name = "MBrBT";
            this.MBrBT.Size = new System.Drawing.Size(47, 16);
            this.MBrBT.TabIndex = 2;
            this.MBrBT.Text = "秒表";
            this.MBrBT.UseVisualStyleBackColor = true;
            this.MBrBT.CheckedChanged += new System.EventHandler(this.MBrBT_CheckedChanged);
            // 
            // DSrBT
            // 
            this.DSrBT.AutoSize = true;
            this.DSrBT.Location = new System.Drawing.Point(180, 19);
            this.DSrBT.Name = "DSrBT";
            this.DSrBT.Size = new System.Drawing.Size(59, 16);
            this.DSrBT.TabIndex = 1;
            this.DSrBT.Text = "定时器";
            this.DSrBT.UseVisualStyleBackColor = true;
            this.DSrBT.CheckedChanged += new System.EventHandler(this.DSrBT_CheckedChanged);
            // 
            // SZrBT1
            // 
            this.SZrBT1.AutoSize = true;
            this.SZrBT1.Checked = true;
            this.SZrBT1.Location = new System.Drawing.Point(27, 20);
            this.SZrBT1.Name = "SZrBT1";
            this.SZrBT1.Size = new System.Drawing.Size(47, 16);
            this.SZrBT1.TabIndex = 0;
            this.SZrBT1.TabStop = true;
            this.SZrBT1.Text = "时钟";
            this.SZrBT1.UseVisualStyleBackColor = true;
            this.SZrBT1.CheckedChanged += new System.EventHandler(this.SZrBT1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "复位";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.secondNum);
            this.groupBox2.Controls.Add(this.minuteNum);
            this.groupBox2.Controls.Add(this.hourNum);
            this.groupBox2.Location = new System.Drawing.Point(93, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间设定";
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "时";
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(202, 29);
            this.secondNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(51, 21);
            this.secondNum.TabIndex = 2;
            this.secondNum.ValueChanged += new System.EventHandler(this.timeNum_ValueChanged);
            // 
            // minuteNum
            // 
            this.minuteNum.Location = new System.Drawing.Point(121, 29);
            this.minuteNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNum.Name = "minuteNum";
            this.minuteNum.Size = new System.Drawing.Size(51, 21);
            this.minuteNum.TabIndex = 1;
            this.minuteNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minuteNum.ValueChanged += new System.EventHandler(this.timeNum_ValueChanged);
            // 
            // hourNum
            // 
            this.hourNum.Location = new System.Drawing.Point(40, 29);
            this.hourNum.Name = "hourNum";
            this.hourNum.Size = new System.Drawing.Size(51, 21);
            this.hourNum.TabIndex = 0;
            this.hourNum.ValueChanged += new System.EventHandler(this.timeNum_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(2, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 253);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "记录";
            this.groupBox3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(10, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(454, 217);
            this.textBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(178, 17);
            this.toolStripStatusLabel1.Text = "Programming By YangXingyu";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(339, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "https://github.com/jn-yxy";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "时钟程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MBrBT;
        private System.Windows.Forms.RadioButton DSrBT;
        public System.Windows.Forms.RadioButton SZrBT1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown secondNum;
        private System.Windows.Forms.NumericUpDown minuteNum;
        private System.Windows.Forms.NumericUpDown hourNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

