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
        Font myFont = new Font("Arial", 12, FontStyle.Regular);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    g.DrawRectangle(Pens.Black, new Rectangle(x * 64, y * 64, 64, 64));
                    g.DrawString($"{x},{y}", myFont, Brushes.Red, new Point(x * 64, y * 64));
                }
            }
        }
    }
}
