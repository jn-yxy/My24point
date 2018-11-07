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
using System.Collections;

namespace MineWweeping
{
    public partial class Mine : Form
    {
        public Mine()
        {
            InitializeComponent();

        }
        public mine saolei = new mine();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static short x, y, ls;
        private void Bt_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            Point qp = new Point((bt.Location.X - 30) / 25, (bt.Location.Y - 80) / 25);
            if (e.Button == MouseButtons.Left)//判断左右键
            {
                if (saolei.MineMap[qp.X, qp.Y] == 1)
                {
                    MessageBox.Show("BOOM!");
                    //踩雷之后显示所有的雷
                    saolei.Showall(x, y);
                }
                else
                {
                    saolei.play(qp.X, qp.Y);

                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (bt.Text.Equals("?"))
                {
                    bt.BackColor = Color.DarkGray;
                    bt.Text = "";
                    saolei.JiLu[qp.X, qp.Y] = ' ';
                    saolei.leishu--;
                }
                else
                {
                    bt.BackColor = Color.Yellow;
                    bt.Text = "?";
                    saolei.JiLu[qp.X, qp.Y] = '?';
                    saolei.leishu++;
                }
            }
            //输出变化
            saolei.Flash(x, y);
            if (saolei.leishu == ls)
            {
                if (saolei.Checkwin(x, y, saolei.leishu))
                {
                    MessageBox.Show("Yeeeeeep!");
                    saolei.Showall(x, y);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button lab in this.Controls.OfType<Button>())
            {
                lab.Visible = false;
            }
            button1.Visible = true;
            x = short.Parse(Xbox.Text.ToString());
            y = short.Parse(Ybox.Text.ToString());
            ls = short.Parse(LSbox.Text.ToString());
            if (x > 10 || y > 10)
            {
                this.Size = new Size(25 * x + 100, 25 * y + 150);
            }
            saolei.build(x, y, ls);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button bt = new Button();
                    bt.Location = new System.Drawing.Point(30 + 25 * i, 80 + 25 * j);
                    bt.Size = new Size(25, 25);
                    bt.BackColor = Color.Gray;
                    bt.Text = "";
                    //调试显示答案用
                    //if (saolei.MineMap[i, j] == 1)
                    //{
                    //    bt.Text = "";
                    //}
                    //else
                    //{
                    //    bt.Text = "";// saolei.JiLu[i,j].ToString();
                    //}

                    bt.TextAlign = ContentAlignment.MiddleCenter;
                    //bt.Click += new System.EventHandler(Bt_Click);
                    bt.MouseDown += new MouseEventHandler(Bt_MouseDown);
                    saolei.buttons[i, j] = bt;
                    this.Controls.Add(bt);
                }
            }
        }

        public class mine
        {
            public int[,] MineMap;
            public Char[,] JiLu;
            public Button[,] buttons;
            public int leishu = 0;
            //建立地雷块
            public void build(int x, int y, int leishu)
            {
                long tick = DateTime.Now.Ticks;
                Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

                if (x * y <= leishu)
                {
                    MessageBox.Show("地雷过多!");
                    return;
                }
                MineMap = new int[x, y];
                JiLu = new char[x, y];
                buttons = new Button[x, y];
                int[] num = new int[x * y];
                for (int i = 0; i < leishu; i++)
                {
                    num[i] = 1;
                }
                ArrayList list = new ArrayList();
                for (int i = 0; i < x * y; i++)
                {
                    int number = ran.Next(0, x * y);
                    while (list.Contains(number))
                    {
                        number = ran.Next(0, x * y);
                    }
                    list.Add(number);
                }

                int jishu = 0;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        MineMap[i, j] = num[(int)list[jishu++]];
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        JiLu[i, j] = '*';
                    }
                }
            }
            //寻找点周边雷的个数
            public int find(Point qp)
            {
                int jishu = 0;
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            continue;
                        }
                        if ((qp.X + i >= 0) && (qp.X + i < Mine.x) && (qp.Y + j >= 0) && (qp.Y + j < Mine.y))
                        {
                            if (MineMap[qp.X + i, qp.Y + j] == 1)
                            {
                                jishu++;
                            }
                        }
                    }
                }
                return jishu;
            }
            //递归炸开块
            public void play(int x, int y)
            {
                int ret;
                Point p = new Point();
                p.X = x; p.Y = y;
                ret = find(p);
                if (ret == 0)
                {
                    JiLu[x, y] = ' ';
                    if ((x - 1) >= 0 && (y - 1) >= 0 && (x - 1) < Mine.x && (y - 1) < Mine.y && (JiLu[x - 1, y - 1] == '*'))
                        play(x - 1, y - 1);
                    if ((x - 1) >= 0 && (y) >= 0 && (x - 1) < Mine.x && (y) < Mine.y && (JiLu[x - 1, y] == '*'))
                        play(x - 1, y);
                    if ((x - 1) >= 0 && (y + 1) >= 0 && (x - 1) < Mine.x && (y + 1) < Mine.y && (JiLu[x - 1, y + 1] == '*'))
                        play(x - 1, y + 1);
                    if ((x) >= 0 && (y - 1) >= 0 && (x) < Mine.x && (y - 1) < Mine.y && (JiLu[x, y - 1] == '*'))
                        play(x, y - 1);
                    if ((x) >= 0 && (y + 1) >= 0 && (x) < Mine.x && (y + 1) < Mine.y && (JiLu[x, y + 1] == '*'))
                        play(x, y + 1);
                    if ((x + 1) >= 0 && (y - 1) >= 0 && (x + 1) < Mine.x && (y - 1) < Mine.y && (JiLu[x + 1, y - 1] == '*'))
                        play(x + 1, y - 1);
                    if ((x + 1) >= 0 && (y) >= 0 && (x + 1) < Mine.x && (y) < Mine.y && (JiLu[x + 1, y] == '*'))
                        play(x + 1, y);
                    if ((x + 1) >= 0 && (y + 1) >= 0 && (x + 1) < Mine.x && (y + 1) < Mine.y && (JiLu[x + 1, y + 1] == '*'))
                        play(x + 1, y + 1);
                }
                else
                {
                    JiLu[x, y] = (char)(ret + '0');
                }
            }
            //显示所有雷
            public void Showall(int x, int y)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (MineMap[i, j] == 1)
                        {
                            buttons[i, j].Text = "◈";
                            buttons[i, j].BackColor = Color.Red;
                        }
                    }
                }
            }
            //胜利判定
            public bool Checkwin(int x, int y, int jishu)
            {
                int js = jishu;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (JiLu[i, j] == '?' && MineMap[i, j] == 1)
                        {
                            js--;
                        }

                    }
                }
                if (js == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //刷新
            public void Flash(int x, int y)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (JiLu[i, j] != '*')
                        {
                            if (JiLu[i,j]=='?')
                            {
                                buttons[i, j].BackColor = Color.Yellow;
                            }
                            else
                            {
                                buttons[i, j].BackColor = Color.DarkGray;
                            }
                            buttons[i, j].Text = JiLu[i, j].ToString();
                        }
                    }
                }
            }
        }
    }
}
