using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0;
            for (int x = 0; (x <= 19); x++)
            {
                y = Math.Sin(Math.PI / 5 * x);
                chart1.Series["Синус"].Points.AddXY(x, y);
                y = Math.Cos(Math.PI / 5 * x);
                chart1.Series["Косинус"].Points.AddXY(x, y);
            }
        }
       
    }
}
