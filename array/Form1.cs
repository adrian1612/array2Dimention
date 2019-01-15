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
            comboBox1.DataSource = Enum.GetValues(typeof(Pattern));
        }

        Graphics g;
        Font myFont = new Font("Arial", 8, FontStyle.Regular);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Draw(Pattern.Pattern1);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Draw(Pattern.Pattern2);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Draw(Pattern.Pattern3);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Draw(Pattern.Pattern4);
            }
        }


        void Draw(Pattern myPattern)
        {
            int myX = 1, myY = 1;
            switch (myPattern)
            {
                case Pattern.Pattern1:
                    myX = 1;
                    myY = 1;
                    break;
                case Pattern.Pattern2:
                    myX = 1;
                    myY = 2;
                    break;
                case Pattern.Pattern3:
                    myX = 2;
                    myY = 1;
                    break;
                case Pattern.Pattern4:
                    myX = 2;
                    myY = 2;
                    break;
                default:
                    break;
            }
            g = CreateGraphics();
            g.Clear(Color.FromName("Control"));
            for (int x = 0; x < numericUpDown1.Value; x += myX)
            {
                for (int y = 0; y < numericUpDown1.Value; y += myY)
                {
                    g.DrawRectangle(Pens.Black, new Rectangle(x * 32, y * 32, 32, 32));
                    g.DrawString($"{x},{y}", myFont, Brushes.Red, new Point(x * 32, y * 32));
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }
    }
}

enum Pattern
{
    Pattern1,
    Pattern2,
    Pattern3,
    Pattern4
}