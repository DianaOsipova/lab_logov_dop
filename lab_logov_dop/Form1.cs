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

namespace lab_logov_dop
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        double width;
        double height;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            width = pictureBox1.Width;
            height = pictureBox1.Height;
        }

        public void DrawAirplane(int x)
        {
            Pen blackPen = new Pen(Color.Black, 2.0f);
            graphics.DrawRectangle(blackPen, new Rectangle(x, 50, 100, 50));
        }

        public void GameStart()
        {
           
            while (true)
                for (int i = -100; i < width; i += 1)
                {
                    graphics.Clear(Color.Gray);
                    DrawAirplane(i);
                    Thread.Sleep(12);
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.PageUnit = GraphicsUnit.Pixel;
            button1.Hide();
            Task.Run(GameStart);
            

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                Task.Run(Show);
            }
        }

        public void Show()
        {
            MessageBox.Show("Diana jaba ogromnaya");
        }
    }
}
