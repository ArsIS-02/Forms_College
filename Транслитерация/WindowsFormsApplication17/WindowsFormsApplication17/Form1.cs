using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        List<string> lex = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохраните список!";
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.FileName = "Транслитерация";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
            StreamWriter sw = new StreamWriter(sfd.FileName);
            //записываем слова:
            string s = null;
            for (int i=0; i<lstRes.Items.Count; ++i)
            {
            s= (string)lstRes.Items[i];
            sw.WriteLine(s);
            }
            sw.Close();
            sw = null;
            MessageBox.Show("Файл " + sfd.FileName + " записан!",
            "Транслитерация");
            }   
            }
        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lex.Count() == 0)
            {
                MessageBox.Show("Вы не загрузили словарь!", "Словари");
                return;
            }
            //русские буквы:
            string rusLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            //транслитерационные "символы":
            string[] transLetters = {"A", "B", "V", "G", "D", "E", "YO", "ZH",
            "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F",
            "KH", "TS", "CH", "SH", "SHCH", "'", "Y", "J", "E", "YU", "YA"};
            lstRes.Items.Clear();
            lstRes.BeginUpdate();
            //ищем в списке подходящие слова -->
            //для всех слов из словаря:
            foreach (string word in lex)
            {
                //создаем новую строку:
                string s = "";
                foreach (char ch in word)
                {
                    int n = rusLetters.IndexOf(ch);
                    if (n > -1) s += transLetters[n];
                }
                lstRes.Items.Add(word + " - " + s);
            } //foreach
            lstRes.EndUpdate();
            lstRes.Items.Add("");
            lstRes.TopIndex = lstRes.Items.Count - 27;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //очищаем словарь:
                lex.Clear();
                //загружаем словарь с диска:
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Загрузите словарь!";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                StreamReader sr = new StreamReader(ofd.FileName);
                //считываем слова:
                string s = null;
                while ((s = sr.ReadLine()) != null)
                {
                lex.Add(s);
                }
                sr.Close();
                sr = null;
                }
        }
    }
}
