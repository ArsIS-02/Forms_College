using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication38
{
    public partial class Form1 : Form
    {
        Bitmap sky = new Bitmap(@"Z:\Кабинет 21\ПИН-3\Арсентьев Фуркадо\готовые\Полет\небо1.jpg"); // небо
        Bitmap plane = new Bitmap(@"Z:\Кабинет 21\ПИН-3\Арсентьев Фуркадо\готовые\Полет\самолет.jpg"); // самолет
        Graphics g; // рабочая графическая поверхность
        int dx; // приращение координаты X,определяет скорость полета
        Rectangle rct; // область, в которой находится самолет
        Boolean demo = true; // true - самолет скрывается в облаках

        public Form1()
        {
            InitializeComponent();
            plane.MakeTransparent(); // прозрачный фон у самолета
            // задать размер формы в соответствии с размером sky
            this.ClientSize = new System.Drawing.Size(
            new Point(BackgroundImage.Width,
            BackgroundImage.Height));
            // будем использовать BackgroundImage формы
            g = Graphics.FromImage(BackgroundImage);
            // исходное положение самолета
            rct.X = -40;
            rct.Y = 20;
            rct.Width = plane.Width;
            rct.Height = plane.Height;
            // скорость полета
            dx = 20; // скорость полета - 2 пикселя/тик_таймера
            timer1.Interval = 20;
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // стираем самолет копированием фона на рабочую поверхность
            g.DrawImage(sky, new Point(0, 0));
            // изменяем положение самолета
            if (rct.X < this.ClientRectangle.Width) rct.X += dx;
            else
            {
                // если граница, задаем заново положение самолета
                rct.X = -40;
                rct.Y = 20;
            }
            // рисуем самолет на рабочей поверхности
            g.DrawImage(plane, rct.X, rct.Y);
            // Метод Invalidate(rct) - перерисовка области rct
            if (!demo) this.Invalidate(rct); // обновить область, где самолет
            else
            {
                // если объект вне области rct, он не виден
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40,
                    sky.Height - 40);
                // показать обновляемую область
                g.DrawRectangle(Pens.Black, reg.X, reg.Y,
                reg.Width - 1, reg.Height - 1);
                this.Invalidate(reg); // обновить область
            }
        }
    }
}
