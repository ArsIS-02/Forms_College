using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        //Инициализациия переменных
        int width;
        int height;
        //отношение высоты окна к ширине:
        double ratio;
        int penWidth = 1;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            //передаем данные из формы
            pen = new Pen(Color.Black, penWidth);
            width = this.Width;
            height = this.Height;
            ratio = (double)height / width;
        }
        private void Draw()
        {
            Graphics gr1 = this.CreateGraphics();
            gr1.Clear(Color.Black);
            Graphics gr = this.CreateGraphics();
            //чертим цветные линии:
            for (int x = 0; x <= width; x += 10)
            {
                pen.Color = Color.Red;
                gr.DrawLine(pen, 0, (int)(x * ratio), width - x, 0);
                pen.Color = Color.Yellow;
                gr.DrawLine(pen, 0, (int)((width - x) * ratio), width - x,
                (int)(width * ratio));
                pen.Color = Color.Blue;
                gr.DrawLine(pen, width - x, (int)(0 * ratio), width,
                (int)((width - x) * ratio));
                pen.Color = Color.Green;
                gr.DrawLine(pen, width - x, (int)(width * ratio), width,
                (int)(x * ratio));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Активизация метода для рисования
            Draw();
        }
    }
}
