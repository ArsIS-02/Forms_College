using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //задаём начальные значения валюты
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;


        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //события обработки кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            //переменные для перевода валюты из одной валюты другую
            string from, to;
            //проверка заполнения полей
            if (textBox2.Text == "")
            {
                from = listBox1.SelectedItem.ToString();
            }
            else
                from = textBox2.Text;

            if (textBox3.Text == "")

            {
                //проверка недочётов
                to = listBox2.SelectedItem.ToString();
            }
            else
            {
                to = textBox3.Text;
            }
            if (from == to)// вывод сообщений о недочётах
                
            {
                MessageBox.Show("Это одна и та же валюта.Перевод невозможен!", "Внимание!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты для перевода!", "Внимание!");
            }
            else
                //обращение к браузеру для перевода валюты
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + " " + from + " %D0%B2 " + to);
            }
        }
    }
}
