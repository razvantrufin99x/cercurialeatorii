using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace cercurialeatorii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen = new Pen(Color.Yellow, 2);

        public void draw(){
            Point[] points = new Point[4];
            points[0] = new Point(0, 0);
            points[1] = new Point(0, 120);
            points[2] = new Point(20, 120);
            points[3] = new Point(20, 0);
        
            
            g.DrawLines(pen, points);

            Random x = new Random();
            
    
            int i = 1 + x.Next(30);
            Pen p = new Pen(System.Drawing.Color.FromArgb(x.Next(256), x.Next(256), x.Next(256)));

            g.DrawEllipse(p, x.Next(100), x.Next(100), i, i);


        
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         g  = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 100; j++)
            {
                draw();
                Thread.Sleep(20);
            }
        }
    }
}
