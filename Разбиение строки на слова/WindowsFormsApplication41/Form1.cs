using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication41
{
    public partial class Form1 : Form
    {
        //создаем список
        List<string> lex = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //закрытие формы
            this.Close();
        }
               
        private void button5_Click(object sender, EventArgs e)
        {
            //очистка списка
            lstRes.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохраните список!";
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.FileName = "Палиндромы";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                //записываем слова:
                string s = null;
                for (int i = 0; i < lstRes.Items.Count; ++i)
                {
                    s = (string)lstRes.Items[i];
                    sw.WriteLine(s);
                }
                sw.Close();
                sw = null;
                MessageBox.Show("Файл " + sfd.FileName + " записан!",
                "Палиндромы");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = txtString.Text;
            //string Pattern = @"\.|\s|,|\?|!|-";
            string Pattern = @"\.|\s|,|\?|!|-|:";
            Regex Splitter =
            new System.Text.RegularExpressions.Regex(Pattern);
            string[] aStr = Splitter.Split(str);
            foreach (string s in aStr)
                if (s != String.Empty)
                    lstRes.Items.Add(s);
            lstRes.TopIndex = lstRes.Items.Count - 22;
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

    }                                                                                                             
}