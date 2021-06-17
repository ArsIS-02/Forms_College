using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using rv;

namespace WindowsFormsApplication46
{
    public partial class Form1 : Form
    {
        //толщина контура:
        float penWidth = 2.0f;
        //начальные координаты элипса:
        int x0 = 0;
        int y0 = 0;
        //максимальные координаты элипса:
        int xmax = 0;
        int ymax = 0;
        //текущие координаты элипса:
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;
        //фигура для рисования:
        string figura = "Rect";
        //поверхность рисования:
        Bitmap bmp = null;
        Graphics g = null;
        //флаг остановки программы:
        bool flgStop = false;
        public Form1()
        {
            InitializeComponent();
            //создаем буферную поверхность рисования:
            bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
            g = Graphics.FromImage(bmp);
            //рисуем качественно:
            g.SmoothingMode = System.
            Drawing.Drawing2D.SmoothingMode.HighQuality;
            pbDraw.Image = bmp;
            xmax = pbDraw.Width - 1;
            ymax = pbDraw.Height - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flgStop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            pbDraw.Invalidate();
            figura = "Ellipse";
            penWidth = 2.0f;
            Draw();
        }
        void Draw()
        {
            flgStop = false;
            //чертим цветные элипсы:
            while (true)
            {
                for (int i = 6; i >= 1; --i)
                {
                    for (int j = 0; j <= 5; ++j)
                    {
                        //стартовый элпса:
                        x1 = x0;
                        y1 = y0;
                        x2 = xmax;
                        y2 = ymax;
                        //выбираем случайный цвет контура:
                        Color clr = rvColor.RandomColor();
                        Pen pen = new Pen(clr, penWidth);
                        //корректируем координаты верхнего элипса
                        int x = 0;
                        int y = 0;
                        while ((x1 <= xmax) && (y1 <= ymax))
                        {
                            if (x1 > x2) x = x2;
                            else x = x1;
                            if (y1 > y2) y = y2;
                            else y = y1;
                            if (figura == "Rect")
                            {
                                //рисуем прямоугольник:
                                g.DrawRectangle(pen, x, y, Math.Abs(x2 - x1),
                                Math.Abs(y2 - y1));
                            }
                            else
                            {
                                //рисуем эллипс:
                                g.DrawEllipse(pen, x, y, Math.Abs(x2 - x1),
                                Math.Abs(y2 - y1));
                            }
                            pbDraw.Invalidate();
                            Thread.Sleep(20);
                            Application.DoEvents();
                            if (flgStop) return;
                            //новые координаты вэлипса:
                            x1 += i;
                            y1 += j;
                            x2 -= i;
                            y2 -= j;
                        } //while
                    } //for j
                } //for i
            }//while true
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            pbDraw.Invalidate();
        }
    }
}
