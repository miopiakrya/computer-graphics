using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.CompGraf.B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            protected override void OnPaint(PaintEventArgs e)
            {

            // Получаем объект Graphics
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Red, 20, 10, 220, 30);
            g.DrawEllipse(Pens.Blue, 20, 40, 220, 90);
            g.DrawRectangle(Pens.Green, 20, 140, 220, 90);
            g.FillEllipse(Brushes.Blue, 260, 40, 220, 90);
            g.FillRectangle(Brushes.Green, 260, 140, 220, 90);
            base.OnPaint(e);

            }
    }

    
}
