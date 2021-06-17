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
        //РИСУЕМ ЗАДАННОЕ ЧИСЛО КРУЖКОВ
        void DrawCircle(int n)
            {
            for (int i = 0; i < n; ++i)
            {
                //радиус:
                int radius = 5 + rvColor.rand.Next(10);
                //случайный цвет:
                Color clr = rvColor.RandomColor();
                //выбираем случайные координаты:
                int x = rvColor.rand.Next(pbDraw.Width - radius);
                int y = rvColor.rand.Next(pbDraw.Height - radius);
                //рисуем цветной кружок:
                g.FillEllipse(new SolidBrush(clr), x, y, 2 * radius,
                2 * radius);
                //g.DrawEllipse(new Pen(clr, 2.0f), x, y, 2 * radius,
                //2 * radius);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        //РИСУЕМ ФИГУРЫ
        {
            DrawCircle(10);
            //обновляем сцену:
            pbDraw.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //СТИРАЕМ ВСЕ КРУЖКИ
            g.Clear(Color.White);
        }
    }
}
