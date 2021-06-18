using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // добавляем один элемент
            comboBox1.Items.Add("Парагвай");
            // добавляем набор элементов
            comboBox1.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
            // добавляем один элемент на определенную позицию
            comboBox1.Items.Insert(1, "Боливия");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // удаляем все элементы
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Парагвай");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(1, "Боливия");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Аргентина");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(1);
        }
    }
}
