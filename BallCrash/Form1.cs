using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BallCrash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, 0, 0, 250, 250);
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == true)
            {
                button1.Text = "暂停";
            }
            else
            {
                button1.Text = "开始";
            }
        }
        int x = 50, y = 0, vx = 5, vy = 7;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, 0, 0, 250, 250);
            g.FillEllipse(b, x, y, 20, 20);
            x += vx;
            y += vy;
            if (x >= 230)
            {
                vx = -vx;
            }
            if (x <= 0)
            {
                vx = -vx;
            }
            if (y >= 230)
            {
                vy = -vy;
            }
            if (y <= 0)
            {
                vy = -vy;
            }
            g.Dispose();
        }
    }
}
