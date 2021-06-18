using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(
((System.Byte)(255)),
((System.Byte)(128)),
((System.Byte)(128)));
            this.TransparencyKey = System.Drawing.Color.FromArgb(
            ((System.Byte)(255)),
            ((System.Byte)(128)),
            ((System.Byte)(128)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
