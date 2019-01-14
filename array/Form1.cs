using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Font myFont = new Font("Arial", 8, FontStyle.Regular);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.FromName("Control"));
            for (int x = 0; x < numericUpDown1.Value; x++)
            {
                for (int y = 0; y < numericUpDown1.Value; y++)
                {
                    g.DrawRectangle(Pens.Black, new Rectangle(x * 32, y * 32, 32, 32));
                    g.DrawString($"{x},{y}", myFont, Brushes.Red, new Point(x * 32, y * 32));
                }
            }
        }
    }
}
