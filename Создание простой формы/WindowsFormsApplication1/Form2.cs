using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Form1 newForm1 = new Form1();
        newForm1.Show();
        Form2 newForm2 = new Form2(newForm1);
        newForm2.Show();
        }
        }
    }

