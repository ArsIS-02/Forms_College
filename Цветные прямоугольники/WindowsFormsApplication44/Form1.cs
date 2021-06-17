using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rv;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        Bitmap bmp = null;
        Graphics g = null;
        public Form1()
        {
            //КОНСТРУКТОР ФОРМЫ
            InitializeComponent();
            //создаем буферную поверхность рисования:
            bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
            g = Graphics.FromImage(bmp);
            //запускаем таймер:
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //РИСУЕМ ЗАДАННОЕ ЧИСЛО ПРЯМОУГОЛЬНИКОВ
        void DrawRect(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                //ширина:
                int width = 50 + rvColor.rand.Next(100);
                //высота:
                int height = 25 + rvColor.rand.Next(60);
                //случайный цвет:
                Color clr = rvColor.RandomColor();
                //выбираем случайные координаты:
                int x = rvColor.rand.Next(pbDraw.Width - width);
                int y = rvColor.rand.Next(pbDraw.Height - height);
                //рисуем цветной прямоугольник:
                g.DrawRectangle(new Pen(clr, 6.0f), x, y, width, height);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        //РИСУЕМ ФИГУРЫ
        {
            DrawRect(10);
            //обновляем сцену:
            pbDraw.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //СТИРАЕМ ВСЕ ПРЯМОУГОЛЬНИКИ
            g.Clear(Color.White);
        }
    }
}

