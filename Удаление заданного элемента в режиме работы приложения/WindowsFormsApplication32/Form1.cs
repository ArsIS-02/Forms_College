using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создаем экземпляр btn класса Button
            Button btn = new Button();
            //Определяем количество элементов управления
            Control prev = (Control)this.Controls[this.Controls.Count - 1];
            //Устанавливаем позицию добавляемых кнопок
            int x1 = prev.Location.X;
            int y1 = prev.Location.Y;
            int height = prev.Height;
            int width = prev.Width;
            btn.Location = new Point(x1 + width + 5, y1 + height + 5);
            btn.Width = prev.Width;
            btn.Height = prev.Height;
            //Добавляем событие для новой кнопки и обработчик button1_Click
            btn.Click += new EventHandler(button1_Click);
            //Устанавливаем свойство Text кнопки
            btn.Text = "Clone";
            //Добавляем экземпляр в коллекцию
            this.Controls.Add(btn);
            //Определяем обработчик для события MouseUp экземпляра кнопки btn
            btn.MouseUp += new MouseEventHandler(button1_MouseUp);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Удаляем данную кнопку
                this.Controls.Remove((Control)sender);
            }
        }
    }
}
