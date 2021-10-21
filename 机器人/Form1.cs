using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace 机器人
{
    public partial class Form1 : Form
    {
        int x = 50;
        int y = 530;  //定位基准
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            while(true)
            {
                Graphics g = e.Graphics;
                if (y>50)//动画相关
                {
                    g.Clear(Color.White);
                    Color c2 = Color.FromArgb(161, 102, 33);//眼睛
                    Brush b2 = new SolidBrush(c2);

                    Color c3 = Color.FromArgb(172, 94, 21);//嘴
                    Brush b3 = new SolidBrush(c3);
                    Color c = Color.FromArgb(249, 246, 248);
                    Brush b = new SolidBrush(c);

                    Color c4 = Color.FromArgb(144, 42, 1);//鼻子
                    Brush b4 = new SolidBrush(c4);

                    Color c5 = Color.FromArgb(239, 170, 91);//鼻子
                    Brush b5 = new SolidBrush(c5);

                    Color c6 = Color.FromArgb(131, 107, 75);//嘴唇
                    Pen p1 = new Pen(c6, 2);

                    Color c7 = Color.FromArgb(112, 184, 239);//水滴
                    Brush b7 = new SolidBrush(c7);
                    Color c8 = Color.FromArgb(198, 226, 253);//水滴
                    Brush b8 = new SolidBrush(c8);
                    Color c9 = Color.FromArgb(40, 82, 107);//水滴
                    Brush b9 = new SolidBrush(c9);
                    Color c10 = Color.FromArgb(191, 142, 49);//阴影
                    Brush b10 = new SolidBrush(c10);

                    Color c1 = Color.FromArgb(253, 228, 135);//面部
                    Brush b1 = new SolidBrush(c1);
                    Color c11 = Color.FromArgb(214, 142, 20);//面部暗
                    Pen p2 = new Pen(c11, 6);

                    Pen p = new Pen(Color.Red, 2);//文字
                    SolidBrush b11 = new SolidBrush(Color.Black);
                    Font f1 = new Font("黑体", 38);
                    g.DrawString("蚌 埠 住 了", f1, b11, 0+x, 330+y);

                    g.FillEllipse(b1, 0 + x, 0 + y, 300, 300);//面部
                    g.DrawEllipse(p2, 0 + x, 0 + y, 300, 300);

                    g.FillEllipse(b2, 60 + x, 75 + y, 50, 90);//眼睛
                    g.FillEllipse(b2, 180 + x, 75 + y, 50, 90);
                    g.FillRectangle(b1, 60 + x, 125 + y, 50, 90);
                    g.FillRectangle(b1, 180 + x, 125 + y, 50, 90);
                    g.FillPie(b1, 60 + x, 100 + y, 50, 55, 0, -180);
                    g.FillPie(b1, 180 + x, 100 + y, 50, 55, 0, -180);

                    g.FillPie(b, 59 + x, 123 + y, 176, 147, 0, 180);//嘴
                    g.FillPie(b3, 60 + x, 145 + y, 175, 130, 0, 180);
                    g.DrawLine(p1, 60 + x, 197 + y, 235 + x, 197 + y);

                    g.FillEllipse(b4, 115 + x, 135 + y, 60, 40);//鼻子
                    g.FillEllipse(b5, 125 + x, 145 + y, 10, 10);

                    g.FillEllipse(b10, 241 + x, 85 + y, 58, 58);//水滴
                    g.FillPie(b9, 241 + x, 72 + y, 58, 63, 0, 180);
                    Point[] point = { new Point(270 + x, 30 + y), new Point(245 + x, 100 + y), new Point(295 + x, 100 + y) };
                    Point[] point2 = { new Point(270 + x, 21 + y), new Point(240 + x, 104 + y), new Point(300 + x, 104 + y) };
                    g.FillPolygon(b9, point2);
                    g.FillPie(b7, 245 + x, 70 + y, 50, 60, 0, 180);
                    g.FillPolygon(b7, point);
                    g.FillEllipse(b8, 262 + x, 55 + y, 20, 50);
                    
                    
                    y-=15;//动画相关
                    Thread.Sleep(300);
                }
                else//动画相关
                {
                    break;
                }
                //break;
            }
            
        }
    }
}
