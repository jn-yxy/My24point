using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float r = 200;
        private PointF center = new PointF(230,350);

        public void drawClock()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            for (int i = 0; i < 60; i++)
            {
                g.ResetTransform();
                g.TranslateTransform(center.X, center.Y);
                g.RotateTransform(i * 6);
                if (i % 5 == 0)
                {
                    g.DrawLine(new Pen(Color.Black, 2.5f), r - 16, 0, r - 5, 0);
                }
                else
                {
                    g.DrawLine(new Pen(Color.Black, 0.5f), r - 10, 0, r - 5, 0);
                }
            }
            float hour, minute, second;
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            hour = hour + minute / 60f + second / 3600f;
            minute = minute + second / 60f;
            g.ResetTransform();
            g.TranslateTransform(center.X, center.Y);//画时针
            g.RotateTransform(hour * 30 + 270 - 6);
            g.DrawLine(new Pen(Color.Black, 3.5f), 0, 0, r * 0.4f, 0f); //绘出时针

            g.ResetTransform();//画分针 ,坐标系恢复到默认状态，Graphics对象回到默认坐标系中绘图。
            g.TranslateTransform(center.X, center.Y);//通过左乘指定的平移来更改系统的坐标原点
            g.RotateTransform(minute * 6 + 270 - 6);
            g.DrawLine(new Pen(Color.Black, 2f), 0, 0, r * 0.6f, 0f);

            g.ResetTransform();//画秒针
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(second * 6 + 270 - 6);
            g.DrawLine(new Pen(Color.Black, 1f), 0, 0, r * 0.75f, 0f);//绘出秒针

            g.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(SZrBT1.Checked)
            {
                drawClock();
            }
            else if (DSrBT.Checked)
            {
                ts = ts.Subtract(new TimeSpan(0, 0, 1));
                label1.Text = ts.ToString();
                if (ts.TotalSeconds <= 0.0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("时间到!!!");
}
            }
            else if (MBrBT.Checked)
            {
                ts = ts.Add(new TimeSpan(0, 0, 0, 1));
                label1.Text = ts.ToString();
            }
            
        }

        private void SZrBT1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            button1.Visible = false;
            button2.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            drawClock();
        }
        TimeSpan ts;
        private void DSrBT_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.Dispose();

            label1.Text = "";
            groupBox3.Visible = false;
            //清除界面
            button1.Text = "开始";
            button1.Visible = true;
            button2.Text = "复位";
            button2.Visible = true;
            groupBox2.Visible = true;
            //显示所需内容
            ts = new TimeSpan((int)hourNum.Value, (int)minuteNum.Value, (int)secondNum.Value);
            label1.Text = ts.ToString();
            //初始化
        }

        private void MBrBT_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = false;
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.Dispose();
            label1.Text = "";
            groupBox2.Visible = false;

            ts = new TimeSpan();
            button1.Text = "开始";
            button1.Visible = true;
            button2.Text = "复位";
            button2.Visible = false;
            label1.Text = ts.ToString();
            textBox1.Text = "";
            groupBox3.Visible = true;

        }

        private void timeNum_ValueChanged(object sender, EventArgs e)
        {
            ts = new TimeSpan((int)hourNum.Value, (int)minuteNum.Value, (int)secondNum.Value);
            label1.Text = ts.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DSrBT.Checked)
            {
                if (timer1.Enabled == false)
                {
                    button1.Text = "暂停";
                    timer1.Enabled = true;
                    groupBox2.Enabled = false;
                }
                else
                {
                    button1.Text = "继续";
                    timer1.Enabled = false;
                    groupBox2.Enabled = true;
                }
            }
            else if (MBrBT.Checked)
            {
                if (button1.Text.Equals("开始"))
                {
                    textBox1.Text = "";
                    button1.Text = "计次";
                    button2.Text = "暂停";
                    button2.Visible = true;
                    timer1.Enabled = true;
                }
                else if (button1.Text.Equals("计次"))
                {
                    textBox1.Text += ts.ToString() + "\r\n";
                    textBox1.Focus();
                    textBox1.Select(textBox1.TextLength, 0);
                    textBox1.ScrollToCaret();
                }
                else if (button1.Text.Equals("停止"))
                {
                    button1.Text = "开始";
                    button2.Visible = false;
                    timer1.Enabled = false;
                    textBox1.Text = "";
                    ts = new TimeSpan();
                    label1.Text = ts.ToString();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DSrBT.Checked)
            {
                timer1.Enabled = false;
                groupBox2.Enabled = true;
                button1.Text = "开始";
                ts = new TimeSpan((int)hourNum.Value, (int)minuteNum.Value, (int)secondNum.Value);
                label1.Text = ts.ToString();
            }
            else if (MBrBT.Checked)
            {
                if (button2.Text.Equals("暂停"))
                {
                    button2.Text = "继续";
                    button1.Text = "停止";
                    timer1.Enabled = false;
                }
                else if (button2.Text.Equals("继续"))
                {
                    button2.Text = "暂停";
                    button1.Text = "计次";
                    timer1.Enabled = true;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jn-yxy");
        }

    }
}
