using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] a = new int[3, 3];
        Graphics gr;
        Pen p = new Pen(Color.Black, 10);
        SolidBrush br = new SolidBrush(Color.Black);
        Font f = new Font("Arial", 34);
        string s;
        static bool b1 = false, b2 = false, b3 = false, b4 = false, b5 = false, b6 = false,
            b7 = false, b8 = false, b9 = false, _iswinx = false, _iswino = false;
        bool[] T = { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
        public void IsWinX(int[,] a, bool _iswinx)// победа крестиков
        {
            p = new Pen(Color.Black, 10);
            gr = panel1.CreateGraphics();
            if ((1 == a[0, 0]) && (1 == a[0, 1]) && (1 == a[0, 2]))//верхняя горизонталь
            {
                gr.DrawLine(p, 0, 20, panel1.Width, 20);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((1 == a[1, 0]) && (1 == a[1, 1]) && (1 == a[1, 2]))//средняя горизонталь
            {
                gr.DrawLine(p, 0, panel1.Height / 2, panel1.Width, panel1.Height/2);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((1 == a[2, 0]) && (1 == a[2, 1]) && (1 == a[2, 2]))//нижняя горизонталь
            {
                gr.DrawLine(p, 0, panel1.Height - 20, panel1.Width, panel1.Height - 20);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((1 == a[0, 0]) && (1 == a[1, 0]) && (1 == a[2, 0]))//левая вертикаль
            {
                gr.DrawLine(p, 25, 0, 25, panel1.Height);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            
            }
            if ((1 == a[0, 1]) && (1 == a[1, 1]) && (1 == a[2, 1]))//средняя вертикаль
            {
                gr.DrawLine(p, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
           
            }
            if ((1 == a[0, 2]) && (1 == a[1, 2]) && (1 == a[2, 2]))//правая вертикаль
            {
                gr.DrawLine(p, panel1.Width - 25, 0, panel1.Width - 25, panel1.Height);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            
            }
            if ((1 == a[0, 0]) && (1 == a[1, 1]) && (1 == a[2, 2]))//главная диагональ
            {
                gr.DrawLine(p, 0, 0, panel1.Width, panel1.Height);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
             
            }
            if ((1 == a[0, 2]) && (1 == a[1, 1]) && (1 == a[2, 0]))//побочная диагональ
            {
                gr.DrawLine(p, panel1.Width, 0, 0, panel1.Height);
                MessageBox.Show("Крестики победили!");
                _iswinx = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
   
            }
        }
        public void IsWinO(int[,] a, bool _iswino)//победа ноликов
        {
            p = new Pen(Color.Black, 10);
            gr = panel1.CreateGraphics();
            if ((0 == a[0, 0]) && (0 == a[0, 1]) && (0 == a[0, 2]))//верхняя горизонталь
            {
                gr.DrawLine(p, 0, 20, panel1.Width, 20);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[1, 0]) && (0 == a[1, 1]) && (0 == a[1, 2]))//средняя горизонталь
            {
                gr.DrawLine(p, 0, panel1.Height / 2, panel1.Width, panel1.Height/2);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[2, 0]) && (0 == a[2, 1]) && (0 == a[2, 2]))//нижняя горизонталь
            {
                gr.DrawLine(p, 0, panel1.Height - 20, panel1.Width, panel1.Height - 20);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[0, 0]) && (0 == a[1, 0]) && (0 == a[2, 0]))//левая вертикаль
            {
                gr.DrawLine(p, 25, 0, 25, panel1.Height);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[0, 1]) && (0 == a[1, 1]) && (0 == a[2, 1]))//средняя вертикаль
            {
                gr.DrawLine(p, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[0, 2]) && (0 == a[1, 2]) && (0 == a[2, 2]))//правая вертикаль
            {
                gr.DrawLine(p, panel1.Width - 25, 0, panel1.Width - 25, panel1.Height);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[0, 0]) && (0 == a[1, 1]) && (0 == a[2, 2]))//главная диагональ
            {
                gr.DrawLine(p, 0, 0, panel1.Width, panel1.Height);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
            if ((0 == a[0, 2]) && (0 == a[1, 1]) && (0 == a[2, 0]))//побочная диагональ
            {
                gr.DrawLine(p, panel1.Width, 0, 0, panel1.Height);
                MessageBox.Show("Нолики победили!");
                _iswino = true;
                panel1.Refresh();
                p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                p7.Refresh(); p8.Refresh(); p9.Refresh();
                p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                p9.Enabled = false;
            }
        }

      

        private void b0_Click(object sender, EventArgs e)//начало игры
        {
            panel1.Refresh();
            b0.Text = "Заново";
            p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh();
            p6.Refresh(); p7.Refresh(); p8.Refresh(); p9.Refresh();
            b1 = false; b2 = false; b3 = false; b4 = false; b5 = false; b6 = false;
            b7 = false; b8 = false; b9 = false;
            p1.Enabled = true; p2.Enabled = true; p3.Enabled = true; p4.Enabled = true;
            p5.Enabled = true; p6.Enabled = true; p7.Enabled = true; p8.Enabled = true;
            p9.Enabled = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = -1;
                }

            }
        }


        private void p1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b1)
            {
                gr = p1.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[0, 0] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b1 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[0, 0] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b1 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }

        }

        private void p2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b2)
            {
                gr = p2.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[0, 1] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b2 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[0, 1] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b2 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;

                }
            }
        }

        private void p3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b3)
            {
                gr = p3.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[0, 2] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b3 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[0, 2] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b3 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }

        private void p4_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b4)
            {
                gr = p4.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[1, 0] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b4 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[1, 0] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b4 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }

        private void p5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b5)
            {
                gr = p5.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[1, 1] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b5 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[1, 1] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b5 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }

        private void p6_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b6)
            {
                gr = p6.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[1, 2] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b6 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[1, 2] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b6 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }

        private void p7_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b7)
            {
                gr = p7.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[2, 0] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b7 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[2, 0] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b7 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }

        private void p8_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b8)
            {
                gr = p8.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[2, 1] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b8 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[2, 1] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b8 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }

        private void p9_MouseClick(object sender, MouseEventArgs e)
        {
            if (!b9)
            {
                gr = p9.CreateGraphics();
                if (MouseButtons.Left == e.Button)
                {
                    p = new Pen(Color.Blue, 10);
                    br = new SolidBrush(Color.Blue);
                    a[2, 2] = 0;
                    s = "O";
                    gr.DrawString(s, f, br, 0, -5);
                    b9 = true;
                }
                if (MouseButtons.Right == e.Button)
                {
                    p = new Pen(Color.Red, 10);
                    br = new SolidBrush(Color.Red);
                    a[2, 2] = 1;
                    s = "X";
                    gr.DrawString(s, f, br, 0, -5);
                    b9 = true;
                }
                IsWinX(a, _iswinx);
                IsWinO(a, _iswino);
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7 && b8 && b9 && !_iswinx && !_iswino)
                {
                    MessageBox.Show("Ничья!");
                    p1.Refresh(); p2.Refresh(); p3.Refresh(); p4.Refresh(); p5.Refresh(); p6.Refresh();
                    p7.Refresh(); p8.Refresh(); p9.Refresh();
                    p1.Enabled = false; p2.Enabled = false; p3.Enabled = false; p4.Enabled = false;
                    p5.Enabled = false; p6.Enabled = false; p7.Enabled = false; p8.Enabled = false;
                    p9.Enabled = false;
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

    }
}