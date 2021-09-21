using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.CompGraf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 1);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawRectangle(myPen, 0, 0, pictureBox1.Size.Width - 1,
            pictureBox1.Size.Height - 1);
            g.Dispose();
        }
    }
}
