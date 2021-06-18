using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
if (checkBox.Checked == true)
{
MessageBox.Show("Флажок " + checkBox.Text + " теперь отмечен");
}
else
{
MessageBox.Show("Флажок " + checkBox.Text + " теперь не отмечен");
}
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
if (checkBox.Checked == true)
{
MessageBox.Show("Флажок " + checkBox.Text + " теперь отмечен");
}
else
{
MessageBox.Show("Флажок " + checkBox.Text + " теперь не отмечен");
}
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
if (checkBox.Checked == true)
{
MessageBox.Show("Флажок " + checkBox.Text + " теперь отмечен");
}
else
{
MessageBox.Show("Флажок " + checkBox.Text + " теперь не отмечен");
}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }
    }
}
